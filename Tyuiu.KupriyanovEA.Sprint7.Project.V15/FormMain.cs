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

        

        private void buttonAdd_KUE_Click(object sender, EventArgs e)
        {
            dataGridViewTable_KUE.Rows.Add();
        }

        private void openToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            openFileDialogTable_KUE.ShowDialog();
            openFilePath = openFileDialogTable_KUE.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewTable_KUE.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTable_KUE.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < cols; i++)
            {
                dataGridViewTable_KUE.Columns[i].Name = arrayValues[0, i];
            }


            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < cols  ; j++)
                {
                    dataGridViewTable_KUE[j, i - 1].Value = arrayValues[i, j];
                }
            }
        }

        private void saveToolStripMenuItem_KUE_Click(object sender, EventArgs e)
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
            string header = "";
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    header += dataGridViewTable_KUE.Columns[j].HeaderText + ";";
                }
                else
                {
                    header += dataGridViewTable_KUE.Columns[j].HeaderText;
                }
            }
            File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);


            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {

                    if (j != columns - 1)
                    {
                        str += dataGridViewTable_KUE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewTable_KUE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
            }
        }

        private void AddRowsToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            dataGridViewTable_KUE.Rows.Add();
        }

        private void AddColumnsToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {

            FormWriteText formWriteText = new FormWriteText();
            formWriteText.ShowDialog();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();// инициализируем колонку
            column.DataPropertyName = "Name";//имя
            column.Name = DataService.Text; //заголовок колонки
            dataGridViewTable_KUE.Columns.Add(column);


        }

        private void CloseTableToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            this.dataGridViewTable_KUE.DataSource = null;
            this.dataGridViewTable_KUE.Rows.Clear();
            this.dataGridViewTable_KUE.Columns.Clear();

        }

        private void developerToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            FormAboutDeveloper formAboutDeveloper = new FormAboutDeveloper();
            formAboutDeveloper.ShowDialog();
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManual formManual = new FormManual();
            formManual.ShowDialog();
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
