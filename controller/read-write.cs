using monitoring_network.DAL;
using System.Xml.Linq;

namespace monitoring_network.controller
{
    public class read_write
    {
        private readonly string logDirectory;
        private readonly string directoryPath = Path.Combine(Environment.CurrentDirectory, "data(xml)", "Address.xml");
        private readonly string errorPath = Path.Combine(Environment.CurrentDirectory, "log", "error", "error.xml");

        public read_write()
        {
            // 设置日志目录路径
            logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log", "SystemLog");
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        // 记录错误信息到日志文件中
        private void LogError(string message, Exception ex)
        {
            string logFilePath = Path.Combine(logDirectory, $"{DateTime.Now:yyyy-MM-dd}系统文件错误.txt");
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
                writer.WriteLine(ex.ToString());
            }
        }

        // XML 操作方法

        /// <summary>
        /// 向 XML 文件中添加一条 Address 记录
        /// </summary>
        /// <param name="address">要添加的 Address 对象（不设置 ID）</param>
        public bool AddXmlRecord(Address address)
        {
            try
            {
                int newId = GetNextId();
                address.Id = newId; // 设置自增 ID
                XElement newElement = AddressToXElement(address);
                XDocument doc;
                if (File.Exists(directoryPath))
                {
                    doc = XDocument.Load(directoryPath);
                }
                else
                {
                    doc = new XDocument(new XElement("ip"));
                }
                doc.Root.Add(newElement);
                doc.Save(directoryPath);
                return true;
            }
            catch (Exception ex)
            {
                LogError($"添加 XML 记录到 {directoryPath} 时发生错误", ex);
                return false;
            }
        }

        /// <summary>
        /// 获取下一个自增 ID
        /// </summary>
        /// <returns>下一个自增 ID</returns>
        private int GetNextId()
        {
            try
            {
                if (File.Exists(directoryPath))
                {
                    XDocument doc = XDocument.Load(directoryPath);
                    var maxId = doc.Root.Elements("List").Max(e => (int?)e.Element("id")) ?? 0;
                    return maxId + 1;
                }
                return 1;
            }
            catch (Exception ex)
            {
                LogError($"获取 {directoryPath} 中的最大 ID 时发生错误", ex);
                return 1;
            }
        }

        /// <summary>
        /// 读取 XML 文件中的所有 Address 记录
        /// </summary>
        /// <returns>XML 文件中的所有 Address 记录</returns>
        public List<Address> ReadXmlRecords()
        {
            try
            {
                XDocument doc = XDocument.Load(directoryPath);
                return doc.Root.Elements("List").Select(XElementToAddress).ToList();
            }
            catch (Exception ex)
            {
                LogError($"读取 {directoryPath} 中的 XML 记录时发生错误", ex);
                return new List<Address>();
            }
        }

        /// <summary>
        /// 根据指定的 ID 获取 XML 文件中对应的 Address 记录
        /// </summary>
        /// <param name="id">要查询的 Address 的 ID</param>
        /// <returns>匹配的 Address 记录，如果未找到则返回 null</returns>
        public Address? GetAddressById(string id)
        {
            try
            {
                XDocument doc = XDocument.Load(directoryPath);
                // 查找具有指定 ID 的 Address 元素
                XElement? addressElement = doc.Root
                    .Elements("List")
                    .FirstOrDefault(e => (string?)e.Element("id") == id);

                if (addressElement != null)
                {
                    return XElementToAddress(addressElement);
                }
                else
                {
                    return null; // 如果未找到匹配的记录，返回 null
                }
            }
            catch (Exception ex)
            {
                LogError($"读取 {directoryPath} 中的 XML 记录时发生错误", ex);
                return null;
            }
        }

        /// <summary>
        /// 更新 XML 文件中的一条 Address 记录
        /// </summary>
        /// <param name="address">更新后的 Address 对象</param>
        public bool UpdateXmlRecord(Address address)
        {
            try
            {
                XDocument doc = XDocument.Load(directoryPath);
                XElement element = doc.Root.Elements("List").FirstOrDefault(e => (int)e.Element("id") == address.Id);
                if (element != null)
                {
                    XElement updatedElement = AddressToXElement(address);
                    element.ReplaceWith(updatedElement);
                    doc.Save(directoryPath);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogError($"更新 {directoryPath} 中的 XML 记录时发生错误", ex);
                return false;
            }
        }

        /// <summary>
        /// 删除 XML 文件中的一条 Address 记录
        /// </summary>
        /// <param name="id">要删除记录的 ID</param>
        public bool DeleteXmlRecord(int id)
        {
            try
            {
                XDocument doc = XDocument.Load(directoryPath);
                XElement element = doc.Root.Elements("List").FirstOrDefault(e => (int)e.Element("id") == id);
                if (element != null)
                {
                    element.Remove();
                    doc.Save(directoryPath);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                LogError($"删除 {directoryPath} 中的 XML 记录时发生错误", ex);
                return false;
            }
        }

        // 辅助方法

        /// <summary>
        /// 将 Address 对象转换为 XElement
        /// </summary>
        /// <param name="address">Address 对象</param>
        /// <returns>XElement 对象</returns>
        private XElement AddressToXElement(Address address)
        {
            return new XElement("List",
                new XElement("id", address.Id),
                new XElement("work", address.Work),
                new XElement("name", address.Name),
                new XElement("add", address.Add),
                new XElement("count", address.Count)
            );
        }

        /// <summary>
        /// 将 XElement 对象转换为 Address 对象
        /// </summary>
        /// <param name="element">XElement 对象</param>
        /// <returns>Address 对象</returns>
        private Address XElementToAddress(XElement element)
        {
            return new Address(
                (int)element.Element("id"),
                (int)element.Element("work"),
                (string)element.Element("name"),
                (string)element.Element("add"),
                (int)element.Element("count")
            );
        }
    }
}
