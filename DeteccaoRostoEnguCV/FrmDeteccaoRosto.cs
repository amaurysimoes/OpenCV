using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

// https://www.youtube.com/watch?v=TCsktW-401o&t=2731s
//https://github.com/opencv/opencv
//https://github.com/opencv/opencv/tree/4.x/data/haarcascades


namespace DeteccaoRostoEnguCV
{
    public partial class FrmDeteccaoRosto : Form
    {
        //criação do objeto:
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        VideoCapture capture;

        public FrmDeteccaoRosto()
        {
            InitializeComponent();
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                { 
                    ProcessarImagem(new Bitmap(Image.FromFile(ofd.FileName)));

                }
            }
        }

        private void abrirAWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(capture != null)
            {
                MessageBox.Show("A Webcam já está iniciada");
                return;
            }

            capture = new VideoCapture(0);
            capture.ImageGrabbed += Capture_ImageGrabbed;
            capture.Start();
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                capture.Retrieve(m);
                ProcessarImagem(m.Bitmap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void paraAWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(capture == null)
            {
                MessageBox.Show("A WebCam já está parada");
                return;
            }

            capture.ImageGrabbed -= Capture_ImageGrabbed;
            capture.Stop();
            capture.Dispose();
            capture = null;
            picImagem.Image = null;
        }

        private void ProcessarImagem(Bitmap bitmap)
        {
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);

            //Vetor de Retangulos
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.1, 1);
            foreach (var rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Green, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }

                }
            }
            picImagem.Image = bitmap;
        }
    }
}
