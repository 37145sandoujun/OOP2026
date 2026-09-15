using SQLiteProductSample;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {

        BindingList<CarReport> _carreports = new BindingList<CarReport>();
        //private readonly BindingList<CarReport> _carreport = new();
        private readonly CarReportRepository _repository = new();
        //設定クラスのオブジェクトを生成
        // Settings settings = Settings.Instance;

        public Form1()
        {
            InitializeComponent();
            dgvRecords.DataSource = _carreports;

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


            carReport.Id = _repository.Add(carReport
                );

            _carreports.Add(carReport);

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

            //削除したいインデックスを指定してリストから削除
            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport)
            {
                tsslbMassage.Text = "削除するレポートを選択してください";
                return;
            }
            _repository.Delete(carReport.Id);
            _carreports.Remove(carReport);

            InputItemsUpdate();
        }

        private void InputItemsUpdate()
        {
            if (dgvRecords.CurrentRow is null || !dgvRecords.CurrentRow.Selected)
                InputItemsAllClear();
        }

        private void btModifyRecode_Click(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                tsslbMassage.Text = "修正するレポートを選択してください";
                return;
            }
            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty)
            {
                tsslbMassage.Text = "記録者、または車名が未入力です";
                return;
            }
            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport)
            {
                tsslbMassage.Text = "修正するレポートを選択してください";
                return;
            }


            //カーレポート管理用リストの該当する要素のデータを書き換える

            _carreports[dgvRecords.CurrentRow.Index].Date = dtpDate.Value;
            _carreports[dgvRecords.CurrentRow.Index].Author = cbAuthor.Text;
            _carreports[dgvRecords.CurrentRow.Index].Maker = getRadioButtonMaker();
            _carreports[dgvRecords.CurrentRow.Index].CarName = cbCarName.Text;
            _carreports[dgvRecords.CurrentRow.Index].Report = tbReport.Text;
            _carreports[dgvRecords.CurrentRow.Index].Picture = pbPicture.Image;
            SetCbAuthor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            _repository.Update(carReport);
            try
            {





                InputItemsAllClear();
                tsslbMassage.Text = "レポートを修正しました";
            }
            catch (Exception ex)
            {
                ShowError("修正エラー", ex);
            }




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvRecords_SelectionChanged(object sender, EventArgs e)
        {
            if ((dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport)
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
                BackColor = cdColor.Color;
                //変更された炉の情報を保存
                Settings.Instance.MainFormBackColor = cdColor.Color.ToArgb();
            }
        }
        //フォームが閉じたら呼ばれるイベントハンドラ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {


            Settings.Instance.Save();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                Settings.Instance.Load();
                BackColor = Color.FromArgb(Settings.Instance.MainFormBackColor);
                _carreports.Clear();
                foreach (var car in _repository.GetAll())
                {
                    _carreports.Add(car);
                }
            }
            catch (Exception ex)
            {
                tsslbMassage.Text = "設定ファイル読み込みエラー";
                MessageBox.Show(ex.Message);//より具体的なエラー
            }


        }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 保存ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            reportSaveFile();
        }

        private void reportSaveFile()
        {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                     sfdReportFileSave.FileName,
                     FileMode.Create))
                    {


                        bf.Serialize(fs, _carreports);
                    }

                }
                catch (Exception ex)
                {
                    tsslbMassage.Text = "ファイル書き出しエラー";
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //ファイルオープン処理
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportOpenFile();
        }

        private void reportOpenFile()
        {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(ofdReportFileOpen.FileName, FileMode.Open, FileAccess.Read))
                    {
                        _carreports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRecords.DataSource = _carreports;
                    }
                    //コンボボックスのすべてを消す
                    cbAuthor.Items.Clear();
                    cbCarName.Items.Clear();

                    //コンボボックスのりれきを再登録

                    foreach (var report in _carreports)
                    {
                        SetCbAuthor(report.Author);
                        SetCbCarName(report.CarName);
                    }

                }
                catch (Exception ex)
                {
                    tsslbMassage.Text = "ファイル書き出しエラー";
                    MessageBox.Show(ex.Message);
                }
            }

        }


        private void ofdReportFileOpen_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void ShowError(string title, Exception ex)
        {
            tsslbMassage.Text = title;
            MessageBox.Show(
                ex.Message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ReloadCarReports()
        {
            _carreports.Clear();
            foreach (var report in _repository.GetAll())
            {
                _carreports.Add(report);
                SetCbAuthor(report.Author);
                SetCbCarName(report.CarName);
            }
            dgvRecords.ClearSelection();
        }

        private void dgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
