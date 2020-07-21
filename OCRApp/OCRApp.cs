using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace OCRApp
{
    public partial class OCRApp : Form
    {
        public static string TessdataDirectory = "C:/Program Files/Tesseract-OCR/tessdata/";
        public static string WhiteList = "ABCDEFGHIJKLMNOPQRATUVWXYZabcdefghijklmnopqrstuvwxyz123456789 ";

        public OCRApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewImage();
        }

        private void OriginalImage_Click(object sender, EventArgs e)
        {
            NewImage();
        }

        private void NewImage()
        {
            OpenFileDialog FileOpener = new OpenFileDialog
            {
                Filter = "Image files (*.png, *.jpg) | *.png; *.jpg | All files (*.*) | *.*"
            };
            if (FileOpener.ShowDialog() == DialogResult.OK)
            {
                OriginalImage.Image = new Mat(FileOpener.FileName);
                ResultTextBox.Text = ProcessImage(new Mat(FileOpener.FileName));
            }
        }
        
        // grayscales the image and then runs the recognizer over it.
        private string ProcessImage(Mat image)
        {
            Tesseract tesseract = new Tesseract(TessdataDirectory, "eng", OcrEngineMode.Default, WhiteList, true);
            Image<Gray, Byte> processedImage = image.ToImage<Gray, Byte>();
            tesseract.SetImage(processedImage);
            tesseract.Recognize();
            string detectedText = tesseract.GetUTF8Text();
            tesseract.Dispose();
            return detectedText;
        }
    }
}
