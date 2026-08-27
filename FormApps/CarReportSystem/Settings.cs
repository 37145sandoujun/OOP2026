using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem
{
    public sealed class Settings

    {

        private static string FileName = "setting.xml";
        //勇逸のSettingオブジェクト
        private static Settings _instance=new Settings();
        public int MainFormBackColor { get; set; }
            = SystemColors.Control.ToArgb();


        public static Settings Instance
        {
            get { return _instance; }
        }
        //外部からNEWさせない
        private Settings() { }


        //設定ファイルから読み込み
        public void Load()
        {
            if (!File.Exists(FileName))
                return;

            using var reader = XmlReader.Create(FileName);
            var serializer = new XmlSerializer(typeof(SettingsData));

            if(serializer.Deserialize(reader)is SettingsData data)
            {
                MainFormBackColor = data.MainForBackColor;
            }
        }


        //設定ファイルを保存
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
