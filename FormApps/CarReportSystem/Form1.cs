using System.ComponentModel;
using static CarReportSystem.CarReport;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {

        BindingList<CarReport> listCarreports = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            dgvRecords.DataSource = listCarreports;
        }

        private void btAddRecord_Click(object sender, EventArgs e)
        {
            ImputItemsAllClear();
            statusStrip1.Text = String.Empty;




            if (cbCarName.Text == String.Empty || cbAuthor.Text == String.Empty)
            {
                tsslbMassage.Text = "記録者、または車名が未入力です";
                return;
            }


            SetCbAuthor(cbAuthor.Text);
            SeCbCarName(cbCarName.Text);

            var carReport = new CarReport
            {
                Date = dtpDate.Value,
                CarName = cbCarName.Text,
                Author = cbAuthor.Text,
                Maker = getRadioButtonMaker(),
                Report = tbReport.Text,
                Picture = pbPicture.Image

            };
            listCarreports.Add(carReport);
        }

        private MakerGroup getRadioButtonMaker()
        {
            if (rbToyota.Checked)
                return MakerGroup.トヨタ;
            if (rbNissan.Checked)
                return MakerGroup.日産;
            if (rbSubaru.Checked)
                return MakerGroup.スバル;
            if (rbHonda.Checked)
                return MakerGroup.ホンダ;
            if (rbImport.Checked)
                return MakerGroup.外車;

            return MakerGroup.その他;
        }



        private void btNewInput_Click(object sender, EventArgs e)
        {
            ImputItemsAllClear();

        }

        private void ImputItemsAllClear()
        {
            cbAuthor.Text = String.Empty;
            cbCarName.Text = String.Empty;
            rbOther.Checked = true;
            dtpDate.Value = DateTime.Today;
            tbReport.Text = String.Empty;
            pbPicture = null;
        }

        private void btOpenPicture_Click(object sender, EventArgs e)
        {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void dgvRecords_Click(object sender, EventArgs e)
        {

            if (dgvRecords.CurrentRow is null) return;

            dtpDate.Value =(DateTime)dgvRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;
            SetRadiButtonMaker((MakerGroup)dgvRecords.CurrentRow.Cells["Meker"].Value);
            cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text= (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            pbPicture.Image= (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;
           
        }

        private void SetRadiButtonMaker(MakerGroup TargetMaker)
        {

            switch (TargetMaker)
            {
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.外車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }

            



        }


        //記入者の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbAuthor(String author)
        {
            if (!cbAuthor.Items.Contains(author))
            

            
            cbAuthor.Items.Add(author);
        }


        //車名の入力履歴をコンボボックスへ登録（重複なし）
        private void SeCbCarName(string carName)
        {
            if(!cbCarName.Items.Contains(carName))
            cbCarName.Items.Add(carName);
        }
    }
}
