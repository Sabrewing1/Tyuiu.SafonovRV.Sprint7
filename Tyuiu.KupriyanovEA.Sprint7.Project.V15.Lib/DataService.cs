using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;

namespace Tyuiu.KupriyanovEA.Sprint7.Project.V15.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string fileDta = File.ReadAllText(filePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows, cols;
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrayValues[i, j] = Convert.ToString(line_r[j]);
                }
            }
            return arrayValues;
        }

        public static string Text = "";

        public int SummDohod(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                res = res + array[i];
            }
            return res;
        }

        public int MinDohod(int[] array)
        {
            int res = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < res)
                {
                    res = array[i];
                }
            }
            return res;
        }

        public int MaxDohod(int[] array)
        {
            int res = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > res)
                {
                    res = array[i];
                }
            }
            return res;
        }
    }
}
