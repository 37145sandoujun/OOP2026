using System.ComponentModel;
using System.Windows.Forms;
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

            statusStrip1.Text = String.Empty;




            if (cbCarName.Text == String.Empty || cbAuthor.Text == String.Empty)
            {
                tsslbMassage.Text = "記録者、または車名が未入力です";
                return;
            }



            var carReport = new CarReport
            {
                Date = dtpDate.Value.Date,
                Author = cbAuthor.Text.Trim(),
                Maker = getRadioButtonMaker(),
                CarName = cbCarName.Text.Trim(),
                Report = tbReport.Text,
                Picture = pbPicture.Image

            };
            listCarreports.Add(carReport);
            SetCbAuthor(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);

            dgvRecords.ClearSelection();
            InputItemsAllClear();


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
            InputItemsAllClear();

        }

        private void InputItemsAllClear()
        {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;

            dgvRecords.CurrentRow.Selected = false;
            dgvRecords.ClearSelection();
        }

        private void btOpenPicture_Click(object sender, EventArgs e)
        {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        

        private void SetRadioButtonMaker(MakerGroup TargetMaker)
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
        private void SetCbCarName(string carName)
        {
            if (!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);
        }

        private void btDeletePicture_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;



        }

        private void btDeleteRecord_Click(object sender, EventArgs e)
        {
            if ((dgvRecords.CurrentRow is null) || (!dgvRecords.CurrentRow.Selected)) return;
            //選択されているインデックスを習得
            int index = dgvRecords.CurrentRow.Index;

            // 削除したいインデックスを指定してからリストから削除;



            listCarreports.RemoveAt(dgvRecords.CurrentRow.Index);

            InputItemsAllClear();
        }

        private void btModifyRecode_Click(object sender, EventArgs e)
       {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                tsslbMassage.Text = "修正するレポートを選択してください";
                return;
            }

            if(String.IsNullOrWhiteSpace(cbAuthor.Text)
                || String.IsNullOrWhiteSpace(cbCarName.Text))
            {
                tsslbMassage.Text = "記録者、または車名が未入力です";
                return;
            }
            //カーレポート管理用リストの該当する要素のデータ

            listCarreports[dgvRecords.CurrentRow.Index].Date = dtpDate.Value;
            listCarreports[dgvRecords.CurrentRow.Index].Author = cbAuthor.Text;
            listCarreports[dgvRecords.CurrentRow.Index].Maker = getRadioButtonMaker();
            listCarreports[dgvRecords.CurrentRow.Index].CarName = cbCarName.Text;
            listCarreports[dgvRecords.CurrentRow.Index].Report = tbReport.Text;
            listCarreports[dgvRecords.CurrentRow.Index].Picture = pbPicture.Image;
            SetCbAuthor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());


            //dgvRecords.CurrentRow.Cells["Date"].Value = dtpDate.Value;
            //dgvRecords.CurrentRow.Cells["Author"].Value = cbAuthor.Text;
            //dgvRecords.CurrentRow.Cells["Maker"].Value = getRadioButtonMaker();
            //dgvRecords.CurrentRow.Cells["CarName"].Value = cbCarName.Text;
            //dgvRecords.CurrentRow.Cells["Report"].Value = tbReport.Text;
            //dgvRecords.CurrentRow.Cells["Picture"].Value = pbPicture.Image;

            dgvRecords.Refresh();//データグリッドビューの
            tsslbMassage.Text = "レポートを修正しました";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvRecords_SelectionChanged(object sender, EventArgs e)
        {
            if ((dgvRecords.CurrentRow?.DataBoundItem        is not CarReport carReport)
                || (!dgvRecords.CurrentRow.Selected)) return;

            dtpDate.Value = carReport.Date;
            cbAuthor.Text = carReport.Author;
            SetRadioButtonMaker(carReport.Maker);
            cbCarName.Text = carReport.CarName;
            tbReport.Text = carReport.Report;
            pbPicture.Image = carReport.Picture;

            
        }

        private void 終了ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                BackColor =cdColor.Color;
            }
        }
    }
}
