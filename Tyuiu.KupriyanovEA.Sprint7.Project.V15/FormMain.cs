using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.KupriyanovEA.Sprint7.Project.V15.Lib;

namespace Tyuiu.KupriyanovEA.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void exitToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение является средством для работы с базами данных.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_KUE_Click(object sender, EventArgs e)
        {
            openFileDialogTable_KUE.ShowDialog();
            openFilePath = openFileDialogTable_KUE.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewTable_KUE.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTable_KUE.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    dataGridViewTable_KUE.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
        }

        private void buttonDownload_KUE_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_KUE.FileName = "OutPutFileTask7.csv";
            saveFileDialogTable_KUE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_KUE.ShowDialog();

            string path = saveFileDialogTable_KUE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewTable_KUE.RowCount;
            int columns = dataGridViewTable_KUE.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTable_KUE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTable_KUE.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAdd_KUE_Click(object sender, EventArgs e)
        {
            dataGridViewTable_KUE.Rows.Add();
        }

        private void buttonInfo_KUE_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTable_KUE_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridViewTable_KUE.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewTable_KUE.Rows[index].HeaderCell.Value = indexStr;
        }
    }
}
