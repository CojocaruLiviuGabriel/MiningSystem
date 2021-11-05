using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningSystem
{
    class Salvare
    {
        StringBuilder csv = new StringBuilder();
        string[] headerTabel = { "Clasa", "accuracy", "precision", "recall", "true negative rate" };
        public void WriteOutputData(List<List<double>> metrici)
        {
            NumeFisier obj = new NumeFisier();
            obj.ShowDialog();
            string filePath = "./../../../OutputReports/" + obj.tbNume.Text + ".csv";
            int i;
            for (i = 0; i < 1; i++)
            {
                var line = string.Format("{0},{1},{2},{3},{4}", headerTabel[i],
                                                                headerTabel[i + 1],
                                                                headerTabel[i + 2],
                                                                headerTabel[i + 3],
                                                                headerTabel[i + 4]);
                csv.AppendLine(line);
            }


            i = 0;
            for (i = 0; i < Form1.claseUniceTraining.Count; i++)
            {
                var newLine = string.Format("{0},{1},{2},{3},{4}", Form1.claseUniceTraining[i],
                                                                   metrici[i][0].ToString(),
                                                                   metrici[i][1].ToString(),
                                                                   metrici[i][2].ToString(),
                                                                   metrici[i][3].ToString());
                csv.AppendLine(newLine);
            }



            var Line = string.Format("{0},{1},{2},{3},{4}", "Medie",
                                                            metrici[i][0].ToString(),
                                                            metrici[i][1].ToString(),
                                                            metrici[i][2].ToString(),
                                                            metrici[i][3].ToString());
            csv.AppendLine(Line);
            File.WriteAllText(filePath, csv.ToString());
        }
    }
}
