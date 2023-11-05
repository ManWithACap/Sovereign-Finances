using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using System.Windows.Forms;
using IronBarCode;
using System.Collections;

namespace SovereignFinances
{

    public partial class SFT_Form : Form
    {

        private FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        private VideoCaptureDevice videoSource;
        private Bitmap capturedImage; // from videoSource's means
        private string barcodeText;
        private string selectedDeviceName;

        public SFT_Form()
        {
            InitializeComponent();
        }

        private void SFT_Form_Load(object sender, EventArgs e)
        {
            /*this.WindowState = FormWindowState.Maximized;*/
            Toolbox.LoadAccounts();
            Toolbox.LoadTransactions();

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();

            if (videoSource.IsRunning)
            {
                B_camOn.Enabled = false;
            }
            else
            {
                B_camOn.Enabled = true;
            }
        }

        private void B_takePhoto_Click(object sender, EventArgs e)
        {
            PB_captured.Image = capturedImage;
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            capturedImage = (Bitmap)eventArgs.Frame.Clone();
            // Display the image in the PictureBox
            PB_photo.Image = (Bitmap)capturedImage.Clone();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        private async void B_scan_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var barcode = await BarcodeReader.ReadAsync(PB_captured.Image);
                barcodeText = barcode.First().Text;

                foreach (Account acct in Toolbox.Accounts)
                {
                    if (acct.AcctNum == barcodeText)
                    {
                        L_acctNum.Text = acct.AcctNum;
                        L_username.Text = acct.CharacterName;
                        L_player.Text = acct.PlayerName;
                        L_balance.Text = acct.Balance.ToString();
                        L_starLevel.Text = acct.StarLevel.ToString();

                        LB_history.Items.Clear();
                        foreach (Transaction tx in acct.Transactions)
                        {
                            LB_history.Items.Add(tx.Label.Text);
                        }
                    }
                }

                L_status.BackColor = System.Drawing.Color.Lime;
                L_status.Text = "DETECTED";
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine(ex.Message);
                L_status.BackColor = System.Drawing.Color.Red;
                L_status.Text = "UNDETECTED";
            }


            Cursor = Cursors.Default;
        }

        private void B_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_camOn_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning == false)
            {
                Cursor = Cursors.WaitCursor;
                videoSource.Start();
                B_camOn.Enabled = false;
                B_camOff.Enabled = true;
            }
            Cursor = Cursors.Default;
        }

        private void B_camOff_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning == true)
            {
                Cursor = Cursors.WaitCursor;
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                B_camOff.Enabled = false;
                B_camOn.Enabled = true;
            }
            Cursor = Cursors.Default;
        }
    }
}