using MonitoringForAirportNetwork.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace monitoring_for_Airport_network.controller
{
    public class directoryStructure
    {
        // 创建工程必要结构
        public void CreateFile()
        {
            // 获取当前工作目录
            string currentDirectory = Environment.CurrentDirectory;
            string directoryPath = Path.Combine(currentDirectory, "data(xml)");
            ExistsFile(directoryPath);
            Address address = new Address(0, 1, "本机测试数据", "127.0.0.1",0);
            CreateXML(directoryPath, address);
            directoryPath = Path.Combine(currentDirectory, "log");
            ExistsFile(directoryPath);
            directoryPath = Path.Combine(directoryPath, "SystemLog");
            ExistsFile(directoryPath);

        }
        static void ExistsFile(string Path)
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }


        public void CreateXML(string pathXML, Address address)
        {
            pathXML = Path.Combine(pathXML, "Address.xml");
            if (!File.Exists(pathXML))
            {
                XDocument doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", null),
                    new XElement("ip",
                        new XAttribute("version", "1.0"),
                        new XElement("List",
                            new XElement("id", address.Id),
                            new XElement("work", address.Work),
                            new XElement("name", address.Name),
                            new XElement("add", address.Add),
                            new XElement("count", address.Count)
                        )
                    )
                );
                doc.Save(pathXML);
            }
        }
        public void LogMessage(string message)
        {
            // 指定日志文件目录
            string logDirectory = Path.Combine(Environment.CurrentDirectory, "log");
            ExistsFile(logDirectory);
            // 获取当前日期，格式为YYYYMMDD
            string currentDate = DateTime.Now.ToString("yyyyMMdd");

            // 构建日志文件名
            string logFileName = $"log_{currentDate}.txt";
            string logFilePath = Path.Combine(logDirectory, logFileName);

            // 记录日志内容到文件
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{message}");
            }
        }

        // 打开指定目录的方法
        public void OpenDirectory()
        {
            try
            {
                string directoryPath = Path.Combine(Environment.CurrentDirectory, "log");
                // 创建一个新的进程启动信息
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = directoryPath,
                    FileName = "explorer.exe"
                };

                // 启动进程
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开目录,请联系管理员: " + ex.Message);
            }
        }
    }
}
