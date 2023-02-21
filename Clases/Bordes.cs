using System.Drawing;

namespace Procesamiento_de_imagenes.Clases
{
    internal class Bordes
    {
        private static Bitmap imagenOriginal;
        private static Bitmap imagenModificada;

        public static Bitmap Laplace(Bitmap imagen)
        {
            int[,] mascara = { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
            imagenOriginal = PreProcesamiento.Grises(imagen);

            AplicarMascara(mascara);

            return PreProcesamiento.Negativo(imagenModificada);
        }

        public static Bitmap Prewitt(Bitmap imagen)
        {
            int[,] mascara = { { 0, 1, 2 }, { -1, 0, 1 }, { -2, -1, 0 } };
            imagenOriginal = PreProcesamiento.Grises(imagen);

            AplicarMascara(mascara);

            return PreProcesamiento.Negativo(imagenModificada);
        }

        public static Bitmap Roberts(Bitmap imagen)
        {
            int[,] mascara = { { -1, 0, -1 }, { 0, 2, 0 }, { 0, 0, 0 } };
            imagenOriginal = PreProcesamiento.Grises(imagen);

            AplicarMascara(mascara);

            return PreProcesamiento.Negativo(imagenModificada);
        }

        public static Bitmap Sobel(Bitmap imagen)
        {
            int[,] mascara = { { -2, -2, 0 }, { -2, 0, 2 }, { 0, 2, 2 } };
            imagenOriginal = PreProcesamiento.Grises(imagen);

            AplicarMascara(mascara);

            return PreProcesamiento.Negativo(imagenModificada);
        }

        private static void AplicarMascara(int[,] mascara)
        {
            int color;
            imagenModificada = new Bitmap(imagenOriginal);

            for (int i = 0; i < imagenOriginal.Width; i++)
            {
                for (int j = 0; j < imagenOriginal.Height; j++)
                {
                    color = 0;

                    for (int k = (i > 0) ? 0 : 1; k < 3 && (i + k - 1) < imagenOriginal.Width; k++)
                    {

                        for (int l = (j > 0) ? 0 : 1; l < 3 && (j + l - 1) < imagenOriginal.Height; l++)
                        {
                            color += imagenOriginal.GetPixel(i + k - 1, j + l - 1).R * mascara[k, l];
                        }
                    }

                    color = (color < 0) ? 0 : ((color > 255) ? 255 : color);

                    imagenModificada.SetPixel(i, j, Color.FromArgb(color, color, color));
                }
            }
        }
    }
}