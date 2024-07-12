using System;

namespace MonitoringForAirportNetwork.DAL
{
    public class Address
    {
        // 使用属性来封装字段
        public int? Id { get; set; }
        public int Work { get; set; }
        public string Name { get; set; }
        public string Add { get; set; }
        public int Count { get; set; }

        // 构造函数可以帮助初始化对象
        public Address(int? id, int work, string name, string add, int count)
        {
            Id = id;
            Work = work;
            Name = name;
            Add = add;
            Count = count;
        }

        // 重写 ToString 方法以便于调试和日志记录
        public override string ToString()
        {
            return $"Id: {Id},Work: {Work}, Name: {Name}, Address: {Add}, Count: {Count}";
        }
    }
}
