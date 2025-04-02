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
        private NewFrameEventHandler newFrameHandler; // campo para manter referência ao delegate

        public frmCapturaImagem()
        {
            InitializeComponent();

            // Configura o PictureBox para ajustar a imagem
            pctBoxCaptura.SizeMode = PictureBoxSizeMode.StretchImage;

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Nenhum dispositivo de vídeo encontrado.");
                btnCapturar.Enabled = false;
                return;
            }

            try
            {
                cmbDispositivos.DataSource = videoDevices;
                cmbDispositivos.DisplayMember = "Name";
                cmbDispositivos.ValueMember = "MonikerString";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o dispositivo de vídeo: " + ex.Message);
                btnCapturar.Enabled = false;
            }
        }
        private void IniciarVideo(string monikerString)
        {
            try
            {
                DisposeVideoSource();

                videoSource = new VideoCaptureDevice(monikerString);
                newFrameHandler = new NewFrameEventHandler(video_NewFrame);
                videoSource.NewFrame += newFrameHandler;
                videoSource.Start();

                btnCapturar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o dispositivo de vídeo: " + ex.Message);
                btnCapturar.Enabled = false;
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
                        pctBoxCaptura.Invoke(new Action(() => UpdatePictureBox(frame)));
                    }
                    else
                    {
                        UpdatePictureBox(frame);
                    }
                }
            }
            catch (Exception ex)
            {
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
                try {
                    string fileName = "captura_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                    CapturedImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar a imagem capturada: " + ex.Message);
                }
                DisposeVideoSource();
                this.DialogResult = DialogResult.OK;
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
                    videoSource.NewFrame -= video_NewFrame;
                    videoSource.SignalToStop();

                    int waitTime = 0;
                    int timeout = 1000;
                    while (videoSource.IsRunning && waitTime < timeout)
                    {
                        System.Threading.Thread.Sleep(100);
                        waitTime += 100;
                    }
                    if (videoSource.IsRunning)
                    {
                            MessageBox.Show("O dispositivo de vídeo não foi finalizado corretamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao finalizar o dispositivo de vídeo: " + ex.Message);
            }
            finally
            {
                videoSource = null;
            }
        }

        private void cmbDispositivos_KeyDown(object sender, KeyEventArgs e)
        {
            if(cmbDispositivos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um dispositivo de vídeo.");
                return;
            }
            else if(e.KeyCode == Keys.Enter && cmbDispositivos.SelectedIndex >= 0)
            {
                try
                {
                    IniciarVideo(cmbDispositivos.SelectedValue.ToString());
                    btnCapturar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao iniciar o dispositivo de vídeo: " + ex.Message);
                    btnCapturar.Enabled = false;
                }
                
            }
        }
    }
}
