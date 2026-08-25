namespace CarReportSystem
{
    public class Settings

    {
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
    }
}
