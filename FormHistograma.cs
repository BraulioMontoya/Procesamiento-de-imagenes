
using System.Drawing;
using System.Windows.Forms;

namespace Procesamiento_de_imagenes
{
    public partial class FormHistograma : Form
    {
        public Bitmap imagen;

        public FormHistograma(Bitmap imagen)
        {
            this.imagen = imagen;

            InitializeComponent();
            Histograma();
        }

        private void Histograma()
        {
            int[,] hist = new int[3, 256];

            rojo.Series["Series1"].Color = Color.Red;
            verde.Series["Series1"].Color = Color.Green;
            azul.Series["Series1"].Color = Color.Blue;

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    hist[0, imagen.GetPixel(i, j).R] += 1;
                    hist[1, imagen.GetPixel(i, j).G] += 1;
                    hist[2, imagen.GetPixel(i, j).B] += 1;
                }
            }

            for (int i = 0; i < 256; i++)
            {
                rojo.Series["Series1"].Points.AddXY(i, hist[0, i]);
                verde.Series["Series1"].Points.AddXY(i, hist[1, i]);
                azul.Series["Series1"].Points.AddXY(i, hist[2, i]);
            }
        }
    }
}
