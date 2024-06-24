using MonitoringForAirportNetwork.DAL;
using System;
using System.Collections.Generic;
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
        public static void CreateFile()
        {
            // 获取当前工作目录
            string currentDirectory = Environment.CurrentDirectory;
            string directoryPath = Path.Combine(currentDirectory, "data(xml)");
            ExistsFile(directoryPath);
            Address address = new Address(0,1, "本机测试数据", "127.0.0.1");
            CreateXML(directoryPath, address);
            directoryPath = Path.Combine(currentDirectory, "log");
            ExistsFile(directoryPath);
            //directoryPath = Path.Combine(directoryPath, "csv");
            //ExistsFile(directoryPath);
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


        public static void CreateXML(string pathXML, Address address)
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
                            new XElement("add", address.Add)
                        )
                    )
                );
                doc.Save(pathXML);
            }
        }

    }
}
