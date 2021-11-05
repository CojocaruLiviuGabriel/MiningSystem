using System;
using System.Collections.Generic;

namespace MiningSystem
{
    class Distanta
    {
        public List<List<double>> DistantaCosinus(ref double[,] mTest, ref double[,] mTraining)
        {
            double dotProduct, sumAsTest, sumAsTraining;
            List<List<double>> distante = new List<List<double>>();
            List<double> temp;


            for (int i = 0; i < mTest.GetLength(0); i++)
            {
                temp = new List<double>();
                for (int j = 0; j < mTraining.GetLength(0); j++)
                {
                    dotProduct = 0;
                    sumAsTest = 0;
                    sumAsTraining = 0;

                    for (int k = 0; k < mTest.GetLength(1); k++)
                    {
                        dotProduct += mTest[i, k] * mTraining[j, k];
                        sumAsTest += Math.Pow(mTest[i, k], 2);
                        sumAsTraining += Math.Pow(mTraining[j, k], 2);
                    }

                    sumAsTest = Math.Sqrt(sumAsTest);
                    sumAsTraining = Math.Sqrt(sumAsTraining);
                    temp.Add((dotProduct / (sumAsTest * sumAsTraining)));

                }
                distante.Add(temp);
            }

            return distante;

        }

        public List<List<double>> DistantaMinkowski(ref double[,] mTest, ref double[,] mTraining, int order)
        {
            double dist;
            List<List<double>> distante = new List<List<double>>();
            List<double> temp;

            for (int i = 0; i < mTest.GetLength(0); i++)
            {
                temp = new List<double>();
                for (int j = 0; j < mTraining.GetLength(0); j++)
                {
                    dist = 0;
                    for (int k = 0; k < mTest.GetLength(1); k++)
                    {
                        dist += Math.Pow(Math.Abs(mTest[i, k] - mTraining[j, k]), order);

                    }
                    dist = Math.Pow(dist, 1.0 / order);
                    temp.Add(dist);


                }
                distante.Add(temp);
            }

            return distante;
        }
    }
}
