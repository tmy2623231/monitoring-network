using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monitoring_network.DAL
{
    public class error
    {
        // 使用属性来封装字段
        public int? Id { get; set; }
        // 使用属性来封装字段
        public int? AddressId { get; set; }
        public string Text { get; set; }
        // 构造函数可以帮助初始化对象
        public error(int? id, int addressId, string text)
        {
            Id = id;
            AddressId = addressId;
            Text = text;
        }

        // 重写 ToString 方法以便于调试和日志记录
        public override string ToString()
        {
            return $"Id: {Id},AddressId: {AddressId}, Text: {Text}";
        }
    }
}
