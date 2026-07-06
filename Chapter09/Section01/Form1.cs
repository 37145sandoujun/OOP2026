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
            DateTime dt1 = dtpDate.Value;
            DayOfWeek dayOfWeek = dt1.DayOfWeek;


            if (DateTime.IsLeapYear(dt1.Year))
            {
                tbOut.Text = "Ç§ÇÈÇ§îNÇ≈ÇÕÇ†ÇËÇ‹ÇπÇÒ";
            }
            else
            {
                tbOut.Text = "Ç§ÇÈÇ§îNÇ≈ÇÕÇ†ÇËÇ‹ÇπÇÒ";
            }
                //switch (dayOfWeek)
                //{
                //    //case DayOfWeek.Saturday:
                //    //    tbOut.Text = "ç°ì˙ÇÕì˙ójì˙Ç≈Ç∑";
                //    //    break;
                //    //case DayOfWeek.Sunday:
                //    //    break;
                //    //case DayOfWeek.Monday:
                //    //    break;
                //    //case DayOfWeek.Tuesday:
                //    //    break;
                //    //case DayOfWeek.Wednesday:
                //    //    break;
                //    //case DayOfWeek.Thursday:
                //    //    break;
                //    //case DayOfWeek.Friday:
                //    //    break;
                //}
        }
    }
}