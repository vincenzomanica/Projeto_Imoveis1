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

            // Configura o PictureBox para ajustar a imagem
            pctBoxCaptura.SizeMode = PictureBoxSizeMode.StretchImage;

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Nenhum dispositivo de vídeo encontrado.");
                return;
            }

            try
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o dispositivo de vídeo: " + ex.Message);
            }
        }

        public void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                using (Bitmap frame = (Bitmap)eventArgs.Frame.Clone())
                {
                    if (pctBoxCaptura.InvokeRequired)
                    {
                        pctBoxCaptura.Invoke(new Action(() =>
                        {
                            UpdatePictureBox(frame);
                        }));
                    }
                    else
                    {
                        UpdatePictureBox(frame);
                    }
                }
            }
            catch (Exception ex)
            {
                // Em ambiente de debug, escreva o erro para monitoramento
                System.Diagnostics.Debug.WriteLine("Erro no NewFrame: " + ex.Message);
            }
        }

        private void UpdatePictureBox(Bitmap frame)
        {
            if (pctBoxCaptura.Image != null)
            {
                pctBoxCaptura.Image.Dispose();
            }
            // Cria uma cópia para manter o frame atual
            pctBoxCaptura.Image = (Bitmap)frame.Clone();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (pctBoxCaptura.Image != null)
            {
                CapturedImage = (Bitmap)pctBoxCaptura.Image.Clone();
                this.DialogResult = DialogResult.OK;
                DisposeVideoSource();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhuma imagem capturada!");
            }
        }

        private void frmCapturaImagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeVideoSource();
        }

        private void DisposeVideoSource()
        {
            try
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame);
                    videoSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao finalizar o dispositivo de vídeo: " + ex.Message);
            }
        }
    }
}
