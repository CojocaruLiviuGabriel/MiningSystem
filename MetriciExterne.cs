using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningSystem
{
    public class MetriciExterne
    {
        double accuracy;
        double precision;
        double recall;
        double trueNegativeRate;
        List<List<double>> metriciPerClasa;

        public MetriciExterne()
        {
            this.accuracy = 0;
            this.precision = 0;
            this.recall = 0;
            this.trueNegativeRate = 0;
        }

        public List<List<double>> CalculMetrici(ConfusionMatrix[] matriciDeEroare)
        {
            metriciPerClasa = new List<List<double>>();
            int i = 0;

            for (i = 0; i < matriciDeEroare.Length; i++)
            {
                metriciPerClasa.Add(new List<double>());

                metriciPerClasa[i].Add(Convert.ToDouble((matriciDeEroare[i].TP + matriciDeEroare[i].TN) / (matriciDeEroare[i].TP + matriciDeEroare[i].FN + matriciDeEroare[i].FP + matriciDeEroare[i].TN)));
                if (matriciDeEroare[i].TP + matriciDeEroare[i].FP != 0)
                {
                    metriciPerClasa[i].Add(Convert.ToDouble(matriciDeEroare[i].TP / (matriciDeEroare[i].TP + matriciDeEroare[i].FP)));
                }
                else
                {
                    metriciPerClasa[i].Add(0);
                }
                if (matriciDeEroare[i].TP + matriciDeEroare[i].FN != 0)
                {
                    metriciPerClasa[i].Add(Convert.ToDouble(matriciDeEroare[i].TP / (matriciDeEroare[i].TP + matriciDeEroare[i].FN)));
                    metriciPerClasa[i].Add(Convert.ToDouble(matriciDeEroare[i].TN / (matriciDeEroare[i].TN + matriciDeEroare[i].FN)));
                }
                else
                {
                    metriciPerClasa[i].Add(0);
                    metriciPerClasa[i].Add(0);
                }


                accuracy += metriciPerClasa[i][0];
                precision += metriciPerClasa[i][1];
                recall += metriciPerClasa[i][2];
                trueNegativeRate += metriciPerClasa[i][3];
            }

            metriciPerClasa.Add(new List<double>());
            accuracy = accuracy / matriciDeEroare.Length;
            precision = precision / matriciDeEroare.Length;
            recall = recall / matriciDeEroare.Length;
            trueNegativeRate = trueNegativeRate / matriciDeEroare.Length;
            metriciPerClasa[i].Add(accuracy);
            metriciPerClasa[i].Add(precision);
            metriciPerClasa[i].Add(recall);
            metriciPerClasa[i].Add(trueNegativeRate);
            return metriciPerClasa;
        }
    }
}
