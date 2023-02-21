using Procesamiento_de_imagenes.Clases;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Procesamiento_de_imagenes
{
    public partial class FormPrincipal : Form
    {
        private string imagenNombre;
        private Bitmap imagenOriginal, imagen;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Abrir imagenModificada",
                Filter = "Archivos (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imagenNombre = openFile.FileName;

                imagenOriginal = new Bitmap(openFile.FileName);
                imagen = new Bitmap(openFile.FileName);
                
                pictureBox.Image = imagen;
                pictureBox.Size = imagen.Size;

                originalToolStripMenuItem.Enabled = true;
                guardarComoToolStripMenuItem.Enabled = true;
                preprocesamientoToolStripMenuItem.Enabled = true;
                histogramaToolStripMenuItem.Enabled = true;
                filtrosToolStripMenuItem.Enabled = true;
                bordesToolStripMenuItem.Enabled = true;
                esqueletizacionToolStripMenuItem.Enabled = true;
                geometriaToolStripMenuItem.Enabled = true;
            }
        }

        private void OriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagen = new Bitmap(imagenOriginal);
            
            pictureBox.Image = imagen;
            pictureBox.Size = imagen.Size;

            guardarToolStripMenuItem.Enabled = false;
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Guardar imagenModificada",
                Filter = "Archivo .bmp|*.bmp|Archivo jpg|*.jpg|Archivo jpeg|*.jpeg|Archivo|*.png"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                imagenNombre = saveFile.FileName;
                guardarToolStripMenuItem.Enabled = true;

                pictureBox.Image.Save(imagenNombre);

            }
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image.Save(imagenNombre);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = PreProcesamiento.Grises(imagen);
        }

        private void BrilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = PreProcesamiento.Brillo(imagen);
        }

        private void OscurecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = PreProcesamiento.Oscurecer(imagen);
        }

        private void BinarizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = PreProcesamiento.Binarizacion(imagen);
        }

        private void NegativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = PreProcesamiento.Negativo(imagen);
        }

        private void quitarFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = PreProcesamiento.QuitarFondo(imagen);
        }

        private void HistogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistograma histograma = new FormHistograma(imagen);
            histograma.ShowDialog();
        }

        private void MediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filtros.Media(imagen);
        }

        private void MediaPonderadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filtros.MediaPonderada(imagen);
        }

        private void PasoAltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filtros.PasaAltas(imagen);
        }

        private void LaplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Bordes.Laplace(imagen);
        }

        private void PrewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Bordes.Prewitt(imagen);
        }

        private void RobertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Bordes.Roberts(imagen);
        }

        private void SobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Bordes.Sobel(imagen);
        }

        private void EsqueletizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Esqueletizacion.GetEsqueletizacion(imagen);
        }

        private void EsacalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelEscala.Visible = true;
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            labelPorcentaje.Text = trackBar.Value + "%";

            pictureBox.Size = new Size(imagen.Width * trackBar.Value / 100, imagen.Height * trackBar.Value / 100);
        }

        private void CerrarEscala_Click(object sender, EventArgs e)
        {
            panelEscala.Visible = false;
        }

        private void Rotacion90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagen.RotateFlip(RotateFlipType.Rotate90FlipNone);

            pictureBox.Size = new Size(pictureBox.Height, pictureBox.Width);
        }

        private void Rotacion180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagen.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox.Refresh();
        }

        private void Rotacion270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagen.RotateFlip(RotateFlipType.Rotate270FlipNone);

            pictureBox.Size = new Size(pictureBox.Height, pictureBox.Width);
        }

        private void TraslacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTraslacion.Visible = true;
        }

        private void Arriba_Click(object sender, EventArgs e)
        {
            Bitmap traslacion;

            if (imagen.Height - 10 > 0)
            {
                traslacion = new Bitmap(imagen.Clone(new Rectangle(0, 10, imagen.Width, imagen.Height - 10), imagen.PixelFormat));
            }
            else
            {
                traslacion = new Bitmap(imagen.Clone(new Rectangle(0, 0, imagen.Width, 1), imagen.PixelFormat));
            }

            imagen = traslacion;
            pictureBox.Image = imagen;

            pictureBox.Size = new Size(imagen.Width * trackBar.Value / 100, imagen.Height * trackBar.Value / 100);
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            Bitmap traslacion;

            if (imagen.Width - 10 > 0)
            {
                traslacion = new Bitmap(imagen.Clone(new Rectangle(10, 0, imagen.Width - 10, imagen.Height), imagen.PixelFormat));
            }
            else
            {
                traslacion = new Bitmap(imagen.Clone(new Rectangle(0, 0, 1, imagen.Height), imagen.PixelFormat));
            }

            imagen = traslacion;
            pictureBox.Image = imagen;

            pictureBox.Size = new Size(imagen.Width * trackBar.Value / 100, imagen.Height * trackBar.Value / 100);
        }

        private void Abajo_Click(object sender, EventArgs e)
        {
            Bitmap traslacion = new Bitmap(imagen.Width, imagen.Height + 10);

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    traslacion.SetPixel(i, j, Color.White);
                }
            }

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    traslacion.SetPixel(i, j + 10, imagen.GetPixel(i, j));
                }
            }

            imagen = traslacion;
            pictureBox.Image = imagen;

            pictureBox.Size = new Size(imagen.Width * trackBar.Value / 100, imagen.Height * trackBar.Value / 100);
        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            Bitmap traslacion = new Bitmap(imagen.Width + 10, imagen.Height);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    traslacion.SetPixel(i, j, Color.White);
                }
            }

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    traslacion.SetPixel(i + 10, j, imagen.GetPixel(i, j));
                }
            }

            imagen = traslacion;
            pictureBox.Image = imagen;

            pictureBox.Size = new Size(imagen.Width * trackBar.Value / 100, imagen.Height * trackBar.Value / 100);
        }

        private void CerrarTraslacion_Click(object sender, EventArgs e)
        {
            panelTraslacion.Visible = false;
        }
    }
}