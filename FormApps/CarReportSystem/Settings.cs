using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem
{
    public sealed class Settings

    {

        private static string FileName = "setting.xml";
        //勇逸のSettingオブジェクト
        private static Settings _instance;
        public int MainFormBackColor { get; set; }
            = SystemColors.Control.ToArgb();


        public static Settings Instance
        {
            get { return _instance; }
        }
        //外部からNEWさせない
        private Settings() { }

        public void Save()
        {
            var data = new SettingsData
            {
                MainForBackColor = MainFormBackColor
            };
            using var writer = XmlWriter.Create(FileName);
            var serializer = new XmlSerializer(typeof(SettingsData));
            serializer.Serialize(writer, data);
        }
    }
    public class SettingsData
    {
        public int MainForBackColor { get; set; }
    }
}
