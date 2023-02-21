using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Procesamiento_de_imagenes.Clases
{
    internal class Filtros
    {
        private static Bitmap imagenOriginal;
        private static Bitmap imagenModificada;

        public static Bitmap Media(Bitmap imagen)
        {
            int[,] mascara = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            imagenOriginal = imagen;

            AplicarMascara(mascara, 9);

            return imagenModificada;
        }

        public static Bitmap MediaPonderada(Bitmap imagen)
        {
            int[,] mascara = { { 1, 1, 1 }, { 1, 2, 1 }, { 1, 1, 1 } };
            imagenOriginal = imagen;

            AplicarMascara(mascara, 10);

            return imagenModificada;
        }

        public static Bitmap PasaAltas(Bitmap imagen)
        {
            int[,] mascara = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
            imagenOriginal = imagen;

            AplicarMascara(mascara, 10);

            return imagenModificada;
        }

        private static void AplicarMascara(int[,] mascara, int divisor)
        {
            int rojo, verde, azul;
            imagenModificada = new Bitmap(imagenOriginal);

            for (int i = 0; i < imagenOriginal.Width; i++)
            {
                for (int j = 0; j < imagenOriginal.Height; j++)
                {
                    rojo = 0;
                    verde = 0;
                    azul = 0;

                    for (int k = (i > 0) ? 0 : 1; k < 3 && (i + k - 1) < imagenOriginal.Width; k++)
                    {
                        for (int l = (j > 0) ? 0 : 1; l < 3 && (j + l - 1) < imagenOriginal.Height; l++)
                        {
                            rojo += imagenOriginal.GetPixel(i + k - 1, j + l - 1).R * mascara[k, l];
                            verde += imagenOriginal.GetPixel(i + k - 1, j + l - 1).G * mascara[k, l];
                            azul += imagenOriginal.GetPixel(i + k - 1, j + l - 1).B * mascara[k, l];
                        }
                    }

                    rojo = (int)(rojo / divisor);
                    rojo = (rojo < 0) ? 0 : ((rojo > 255) ? 255 : rojo);

                    verde = (int)(verde / divisor);
                    verde = (verde < 0) ? 0 : ((verde > 255) ? 255 : verde);
                    
                    azul = (int)(azul / divisor);
                    azul = (azul < 0) ? 0 : ((azul > 255) ? 255 : azul);

                    imagenModificada.SetPixel(i, j, Color.FromArgb(rojo, verde, azul));
                }
            }
        }
    }
}
