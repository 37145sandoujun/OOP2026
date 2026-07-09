using System.Globalization;

namespace Section01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }




        private void btGet1_Click(object sender, EventArgs e)
        {



            DateTime date = dtpDate.Value;
            tbOut.Text = date.AddDays((double)numDay.Value).ToString();
        }

        private void btBirthCalc_Click(object sender, EventArgs e)
        {
            DateTime birth = dtpDate2.Value;
            DateTime today = DateTime.Today;

            tbOut2.Text = (GetAge(birth, today)) + "歳です";

            TimeSpan ts = today.Date - birth.Date;
            tbOut3.Text = $"生まれてから{ts.Days}日めです";


            DateTime dates = dtpDate.Value;
            DateTime date = new DateTime(dates.Year, dates.Month, dates.Day);
            var bars = dtpDate2.Value;
            var nawbars = new DateTime(date.Year, bars.Month, bars.Day);

            if ((date - nawbars).Days < 0)
            {
                tbOut5.Text = ((nawbars - date).Days).ToString();
            }
            else if ((date - nawbars).Days > 0)
            {
                tbOut5.Text = (365 - (date - nawbars).Days).ToString();
            }
            else if (date == nawbars)
            {
                tbOut5.Text = "今日が誕生日！！";
            }



            var sdate = birth;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var shortDayOfWeek = culture.DateTimeFormat.GetShortestDayName(date.DayOfWeek);
            tbOut4.Text = $"生まれた{birth.Month}月{birth.Day}日は第{NthWeek(birth)}週の{shortDayOfWeek}曜日です";
            //年齢を求めるメソッド
            static int GetAge(DateTime birthday, DateTime targetDay)
            {
                var age = targetDay.Year - birthday.Year;
                if (targetDay < birthday.AddYears(age))
                {
                    age--;
                }
                return age;
            }
            //指定した日が第何週か求める
            static int NthWeek(DateTime date)
            {
                var firstDay = new DateTime(date.Year, date.Month, 1);
                var firstDayOfWeek = (int)(firstDay.DayOfWeek);
                return (date.Day + firstDayOfWeek - 1) / 7 + 1;


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}