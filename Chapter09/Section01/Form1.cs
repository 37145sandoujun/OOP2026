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
            tbOut3.Text = (today.Date - birth.Date) + "ì˙åoâﬂ";
            tbOut2.Text = (today.Year - birth.Year) + "çŒÇ≈Ç∑";
        }
    }
}