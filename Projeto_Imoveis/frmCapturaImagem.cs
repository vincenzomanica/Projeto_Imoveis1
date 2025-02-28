using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Projeto_Imoveis
{
    public partial class frmCapturaImagem : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public Bitmap CapturedImage { get; private set; }
        public frmCapturaImagem()
        {
            InitializeComponent();


            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Nenhum dispositivo de vídeo encontrado.");
                return;
            }
            //Selecionar primeiro dispositivo de video
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();

        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Exibir a imagem capturada no PictureBox
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pctBoxCaptura.Image = bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (pctBoxCaptura.Image != null)
            {
                CapturedImage = (Bitmap)pctBoxCaptura.Image.Clone();
                this.DialogResult = DialogResult.OK;
                this.Close();
                MessageBox.Show("Imagem capturada com sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhuma imagem capturada!");
            }
        }
        private void frmCapturaImagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
        }
    }
}
