using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using System.Windows.Forms;
using IronBarCode;

namespace SovereignFinances
{

    public partial class SFT_Form : Form
    {
        private FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        private VideoCaptureDevice videoSource;
        private Bitmap capturedImage; // from videoSource's means
        private string barcodeText;

        public SFT_Form()
        {
            InitializeComponent();
        }

        private void SFT_Form_Load(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
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
            var barcode = await BarcodeReader.ReadAsync(PB_captured.Image);
            barcodeText = barcode.First().Text;
        }
    }
}