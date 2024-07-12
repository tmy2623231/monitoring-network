using MonitoringForAirportNetwork.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace monitoring_for_Airport_network.controller
{
    public class pollingIP
    {


        // 这是一个异步方法，用于Ping测试给定的IP地址列表
        public async Task<Dictionary<Address, bool>> PingAddressesAsync()
        {
            // 创建一个字典用于存储Ping测试结果
            var pingResults = new Dictionary<Address, bool>();

            read_write read_Write = new read_write();
            List<Address> addresses = read_Write.ReadXmlRecords();

            // 用于并发控制的Task列表
            var tasks = new List<Task>();

            // 遍历所有地址对象
            foreach (var address in addresses)
            {
                // 只对Work == 1的地址进行Ping测试
                if (address.Work == 1)
                {
                    // 创建并启动Ping测试任务
                    var task = PingAddressAsync(address.Add)
                        .ContinueWith(t => {
                            lock (pingResults) // 锁定字典以确保线程安全
                            {
                                pingResults[address] = t.Result;
                            }
                        });

                    tasks.Add(task);
                }
            }

            // 等待所有任务完成
            await Task.WhenAll(tasks);

            // 返回Ping测试结果字典
            return pingResults;
        }

        // 这是一个异步方法，用于Ping测试单个IP地址
        private async Task<bool> PingAddressAsync(string ipAddress)
        {
            using (var ping = new Ping()) // 创建Ping对象
            {
                try
                {
                    // 发送Ping请求，超时设置为1000毫秒
                    PingReply reply = await ping.SendPingAsync(ipAddress, 1000);
                    return (reply.Status == IPStatus.Success);
                }
                catch (PingException)
                {
                    // 如果发生Ping异常，返回异常结果和备注
                    return (false);
                }
                catch (Exception)
                {
                    // 捕获其他所有异常
                    return (false);
                }
            }
        }
    }
}
