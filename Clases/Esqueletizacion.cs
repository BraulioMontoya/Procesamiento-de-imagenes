using System.Drawing;

namespace Procesamiento_de_imagenes.Clases
{
    internal class Esqueletizacion
    {
        public static Bitmap GetEsqueletizacion(Bitmap imagen)
        {
            bool borrar = true;

            PreProcesamiento.Binarizacion(imagen);
            PreProcesamiento.Negativo(imagen);

            while (borrar)
            {
                borrar = false;

                for (int i = 1; i < imagen.Width - 1; i++)
                {
                    for (int j = 1; j < imagen.Height - 1; j++)
                    {
                        if (imagen.GetPixel(i, j).R == 255)
                        {
                            if (imagen.GetPixel(i - 1, j).R == 0 || imagen.GetPixel(i, j + 1).R == 0 || imagen.GetPixel(i + 1, j).R == 0 || imagen.GetPixel(i, j - 1).R == 0)
                            {
                                if (CoincidePlantilla(imagen.Clone(new Rectangle(i - 1, j - 1, 3, 3), imagen.PixelFormat)))
                                {
                                    imagen.SetPixel(i, j, Color.FromArgb(2, 2, 2));
                                }
                                else
                                {
                                    imagen.SetPixel(i, j, Color.FromArgb(3, 3, 3));
                                    borrar = true;
                                }
                            }
                        }
                    }
                }

                for (int i = 1; i < imagen.Width - 1; i++)
                {
                    for (int j = 1; j < imagen.Height - 1; j++)
                    {
                        if (imagen.GetPixel(i, j).R == 3)
                            imagen.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                }
            }

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    if (imagen.GetPixel(i, j).R == 2)
                        imagen.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }
            }

            return PreProcesamiento.Negativo(imagen);
        }

        private static bool CoincidePlantilla(Bitmap mascara)
        {
            // Primer plantilla { { A, A, A }, { 0, p, 0 }, { B, B, B } }
            if (mascara.GetPixel(1, 0).R != 255 && mascara.GetPixel(1, 2).R != 255)
            {
                if (mascara.GetPixel(0, 0).R != 0 || mascara.GetPixel(0, 1).R != 0 || mascara.GetPixel(0, 2).R != 0)
                    if (mascara.GetPixel(2, 0).R != 0 || mascara.GetPixel(2, 1).R != 0 || mascara.GetPixel(2, 2).R != 0)
                        return true;
            }
            
            if (mascara.GetPixel(0, 1).R != 255 && mascara.GetPixel(2, 1).R != 255)
            {
                if (mascara.GetPixel(0, 0).R != 0 || mascara.GetPixel(1, 0).R != 0 || mascara.GetPixel(2, 0).R != 0)
                    if (mascara.GetPixel(0, 2).R != 0 || mascara.GetPixel(1, 2).R != 0 || mascara.GetPixel(2, 2).R != 0)
                        return true;
            }
            
            // Segunda plantilla { { A, A, A }, { A, p, 0 }, { A, 0, 2 } }
            if (mascara.GetPixel(2, 1).R != 255)
            {
                if (mascara.GetPixel(0, 0).R != 0 || mascara.GetPixel(0, 1).R != 0 || mascara.GetPixel(0, 2).R != 0)
                {
                    if (mascara.GetPixel(1, 0).R != 255 && mascara.GetPixel(2, 0).R == 2)
                        if (mascara.GetPixel(1, 2).R != 0 || mascara.GetPixel(2, 2).R != 0)
                            return true;

                    if (mascara.GetPixel(1, 2).R != 255 && mascara.GetPixel(2, 2).R == 2)
                        if (mascara.GetPixel(1, 0).R != 0 || mascara.GetPixel(2, 0).R != 0)
                            return true;
                }
            }

            if (mascara.GetPixel(0, 1).R != 255)
            {
                if (mascara.GetPixel(2, 0).R != 255 || mascara.GetPixel(2, 1).R != 0 || mascara.GetPixel(2, 2).R != 0)
                {
                    if (mascara.GetPixel(1, 0).R != 255 && mascara.GetPixel(2, 0).R == 2)
                        if (mascara.GetPixel(1, 2).R != 0 || mascara.GetPixel(2, 2).R != 0)
                            return true;

                    if (mascara.GetPixel(1, 2).R != 255 && mascara.GetPixel(2, 2).R == 2)
                        if (mascara.GetPixel(1, 0).R != 0 || mascara.GetPixel(2, 0).R != 0)
                            return true;
                }
            }

            return false;
        }
    }
}
