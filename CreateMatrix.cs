using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningSystem
{
    public class CreateMatrix
    {
        public void CitesteFisierArff(out double[,] Matrice, string caleFisier)
        {
            List<string> s = new List<string>();
            uint numarLinii = 0;
            uint numarColoane = 0;

            StreamReader streamReader = new StreamReader(caleFisier);

            string[] linii = streamReader.ReadLine().Split(' ');
            numarLinii = Convert.ToUInt32(linii[1]);

            string[] coloane = streamReader.ReadLine().Split(' ');
            numarColoane = Convert.ToUInt32(coloane[1]);

            string linieDinFisier;

            while ((linieDinFisier = streamReader.ReadLine()) != null)
            {
                if ((linieDinFisier.StartsWith("@")) || (linieDinFisier.StartsWith("#")) || (linieDinFisier == ""))
                {
                }
                else
                {
                    int index = linieDinFisier.IndexOf("#");
                    string aux = linieDinFisier.Substring(0, index);
                    s.Add(aux);
                }
            }

            Matrice = CreateMatrixFromArff(s, numarLinii, numarColoane);
        }

        public double[,] CreateMatrixFromArff(List<string> lines, uint numberOfLines, uint numberOfColumns)
        {
            double[,] matrix = new double[numberOfLines, numberOfColumns];


            for (var indexLine = 0; indexLine < lines.Count; indexLine++)
            {
                string[] lineSplit = lines[indexLine].Split(' ');

                for (var indexLineSplit = 0; indexLineSplit < lineSplit.Length-1; indexLineSplit++)
                {
                    string[] valueSplit = lineSplit[indexLineSplit].Split(':');
                    int key = Convert.ToInt32(valueSplit[0]);
                    Int16 value = Convert.ToInt16(valueSplit[1]);

                    matrix[indexLine, key] = value;
                }
            }

            return matrix;
        }


        public List<string> ClaseDinFisier(string caleFisier)
        {
            List<string> temp = new List<string>();
            StreamReader streamReader = new StreamReader(caleFisier);

            string linieDinFisier;

            while ((linieDinFisier = streamReader.ReadLine()) != null)
            {
                if (!linieDinFisier.StartsWith("@") && !linieDinFisier.StartsWith("#") && linieDinFisier.Contains("c"))
                {
                    int index = linieDinFisier.IndexOf("#");
                    string[] aux = linieDinFisier.Substring(index + 1).Split();
                    temp.Add(aux[1]);
                }
            }

            return temp;
        }

        public List<string> ClaseDinFisierTopiceUnice(string caleFisier)
        {
            List<string> temp = new List<string>();
            StreamReader streamReader = new StreamReader(caleFisier);

            string linieDinFisier;

            while ((linieDinFisier = streamReader.ReadLine()) != null)
            {
                if (!linieDinFisier.StartsWith("@") && !linieDinFisier.StartsWith("#") && linieDinFisier.Contains("c"))
                {
                    int index = linieDinFisier.IndexOf("#");
                    string[] aux = linieDinFisier.Substring(index + 1).Split();
                    temp.Add(aux[1]);
                }
            }

            temp = temp.Distinct().ToList();
            return temp;
        }
    }
}
