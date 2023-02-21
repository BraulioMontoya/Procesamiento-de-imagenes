using System.Drawing;

namespace Procesamiento_de_imagenes.Clases
{
    internal class PreProcesamiento
    {
        public static Bitmap Grises(Bitmap imagen)
        {
            int color;

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    color = (imagen.GetPixel(i, j).R + imagen.GetPixel(i, j).G + imagen.GetPixel(i, j).B) / 3;

                    imagen.SetPixel(i, j, Color.FromArgb(color, color, color));
                }
            }
            
            return imagen;
        }

        public static Bitmap Brillo(Bitmap imagen)
        {
            int rojo, verde, azul;

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    rojo = (int)(imagen.GetPixel(i, j).R * 1.1);
                    rojo = (rojo > 255) ? 255 : rojo;

                    verde = (int)(imagen.GetPixel(i, j).G * 1.1);
                    verde = (verde > 255) ? 255 : verde;

                    azul = (int)(imagen.GetPixel(i, j).B * 1.1);
                    azul = (azul > 255) ? 255 : azul;

                    imagen.SetPixel(i, j, Color.FromArgb(rojo, verde, azul));
                }
            }

            return imagen;
        }

        public static Bitmap Oscurecer(Bitmap imagen)
        {
            int rojo, verde, azul;

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    rojo = (int)(imagen.GetPixel(i, j).R * 0.9);
                    rojo = (rojo < 0) ? 0 : rojo;

                    verde = (int)(imagen.GetPixel(i, j).G * 0.9);
                    verde = (verde < 0) ? 0 : verde;

                    azul = (int)(imagen.GetPixel(i, j).B * 0.9);
                    azul = (azul < 0) ? 0 : azul;

                    imagen.SetPixel(i, j, Color.FromArgb(rojo, verde, azul));
                }
            }

            return imagen;
        }

        public static Bitmap Binarizacion(Bitmap imagen)
        {
            int color;

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    color = ((imagen.GetPixel(i, j).R + imagen.GetPixel(i, j).G + imagen.GetPixel(i, j).B) < 175) ? 0 : 255;

                    imagen.SetPixel(i, j, Color.FromArgb(color, color, color));
                }
            }

            return imagen;
        }

        public static Bitmap Negativo(Bitmap imagen)
        {
            int rojo, verde, azul;

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    rojo = 255 - imagen.GetPixel(i, j).R;
                    verde = 255 - imagen.GetPixel(i, j).G;
                    azul = 255 - imagen.GetPixel(i, j).B;

                    imagen.SetPixel(i, j, Color.FromArgb(rojo, verde, azul));
                }
            }

            return imagen;
        }

        public static Bitmap QuitarFondo(Bitmap imagen)
        {
            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    if (imagen.GetPixel(i, j).R == 255)
                    {
                        imagen.SetPixel(i, j, Color.Transparent);
                    }
                }
            }

            return imagen;
        }
    }
}
