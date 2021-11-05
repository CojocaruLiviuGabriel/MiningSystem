using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningSystem
{
    class Normalizare
    {
        public void NormalizareBinara(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        public void NormalizareLogaritmDublu(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1 + Math.Log10(1 + Math.Log10((double)matrix[i, j]));
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        public void NormalizareNominala(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double max = -1;
            double[] maxValue = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                maxValue[i] = max;
                max = 0;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = matrix[i, j] / maxValue[i];
                }
            }

        }

        public void NormalizareSuma1(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[] sumeLini = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                sumeLini[i] = 0;

                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }

                    sumeLini[i] = sumeLini[i] + matrix[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = matrix[i, j] / sumeLini[i];
                }
            }
        }
    }
}
