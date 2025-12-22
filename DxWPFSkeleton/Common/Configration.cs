using DXWPFSkeleton.Util;
using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace DXWPFSkeleton.Common
{
    public class Configuration
    {
        private const string FILE_ENV = $"env.xml";

        [XmlRoot("Config")]
        public class Environment
        {
            public string PLC   { get; set; } = "opc.tcp://192.168.200.1:4840";
            public string LAN01 { get; set; } = "192.168.200.101";
            public string LAN02 { get; set; } = "192.168.200.102";
        }

        // env.xml
        public static Environment Env { get; set; } = new Environment();

        public static void Load(string home)
        {
            try {

                var path = Path.Combine(home, "Config");

                var env = File.ReadAllText(Path.Combine(path, FILE_ENV), Encoding.UTF8);

                using (TextReader r = new StringReader(env)) {
                    XmlSerializer serializer = new XmlSerializer(typeof(Environment));
                    Env = (Environment)serializer.Deserialize(r);
                }
            }
            catch (Exception ex) {
                Logger.Instance.Write(LEVEL.ERROR, ex.Message);
            }
        }
    }
}
