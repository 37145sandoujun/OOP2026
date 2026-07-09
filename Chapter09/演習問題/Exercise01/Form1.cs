using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercise01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            tbOut1.Text = now.ToString("yyyy/MM/dd HH:mm");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var now =  DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = now.ToString("ggyy年M月d年 HH時mm分ss秒", culture);
            tbOut2.Text = $"{str}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = now.ToString("gg yy年 M月 d年　(dddd)", culture);
            tbOut3.Text = $"{str}";
        }
    }
}
