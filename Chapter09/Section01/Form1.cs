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
           
            tbOut2.Text = (GetAge(birth,today)) + "çŒÇ≈Ç∑";

            TimeSpan ts = today.Date - birth.Date;
            tbOut3.Text = $"ê∂Ç‹ÇÍÇƒÇ©ÇÁ{ts.Days}ì˙ÇﬂÇ≈Ç∑";



            var date = birth;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var shortDayOfWeek = culture.DateTimeFormat.GetShortestDayName(date.DayOfWeek);
            tbOut4.Text = $"ê∂Ç‹ÇÍÇΩ{birth.Month}åé{birth.Day}ì˙ÇÕëÊ{NthWeek(birth)}èTÇÃ{shortDayOfWeek}ójì˙Ç≈Ç∑";

            static int GetAge(DateTime birthday, DateTime targetDay)
            {
                var age = targetDay.Year - birthday.Year;
                if (targetDay < birthday.AddYears(age))
                {
                    age--;
                }
                return age;
            }
            static int NthWeek(DateTime date)
            {
                var firstDay = new DateTime(date.Year, date.Month, 1);
                var firstDayOfWeek = (int)(firstDay.DayOfWeek);
                return (date.Day + firstDayOfWeek - 1) / 7 + 1;


            }
        }
    }
}