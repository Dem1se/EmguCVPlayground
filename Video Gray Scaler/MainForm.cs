using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        VideoCapture CaptureCam;
        Image<Bgr, Byte> OriginalImage;
        Image<Gray, Byte> ProcessedImage;
        string PathToFile;
        bool Paused = false;

        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog
            {
                Title = "Open Video File",
                Filter = "MP4 files (*.mp4) | *.mp4"
            };

            if (OpenFile.ShowDialog() == DialogResult.OK)
                PathToFile = OpenFile.FileName;
            else
                CvInvoke.DestroyWindow("MainForm");

            try
            {
                CaptureCam = new VideoCapture(PathToFile);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Application.Idle += new EventHandler(ProcessFunction);
        }

        protected void ProcessFunction(object sender, EventArgs e)
        {
            if (Paused) return;
            OriginalImage = CaptureCam.QueryFrame().ToImage<Bgr, Byte>();
            if (OriginalImage == null) return;
            //ProcessedImage = OriginalImage.InRange(new Bgr(50, 50, 50), new Bgr(255, 255, 255));
            //ProcessedImage = ProcessedImage.SmoothGaussian(9);
            ProcessedImage = OriginalImage.Convert<Gray, Byte>();
            original.Image = OriginalImage;
            processed.Image = ProcessedImage;
        }

        private void PauseOrPlay_Click(object sender, EventArgs e)
        {
            Paused = !Paused;
            PauseOrPlay.Text = Paused ? "Play" : "Pause";
        }
    }
}
