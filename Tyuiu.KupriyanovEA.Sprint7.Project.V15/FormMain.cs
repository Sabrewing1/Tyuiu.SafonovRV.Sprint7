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
            if (dataGridViewTable_KUE.Columns.Count == 0) 
            { 
                MessageBox.Show("Сначала добавьте столбцы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewTable_KUE.Rows.Add();
            }
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
            this.dataGridViewTable_KUE.Rows.Clear();
            this.dataGridViewTable_KUE.Columns.Clear();

        }

        private void developerToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            FormAboutDeveloper formAboutDeveloper = new FormAboutDeveloper();
            formAboutDeveloper.ShowDialog();
        }

        private void RemoveRowToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_KUE.CurrentRow != null)
            {
                dataGridViewTable_KUE.Rows.Remove(dataGridViewTable_KUE.CurrentRow);
            }
        }

        private void RemoveColumnToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            int CellCount = dataGridViewTable_KUE.Columns.Count - 1;
            dataGridViewTable_KUE.Columns.Remove(dataGridViewTable_KUE.Columns[CellCount]);
        }

        private void DohodToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnDohod_KUE.Text);

            toolStripTextBoxInputColumnDohod_KUE.Clear();

            // Создаем массив для хранения данных из столбца
            int[] columnData = new int[dataGridViewTable_KUE.Rows.Count];

            // Используем цикл для записи данных из столбца в массив
            for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
            {
                columnData[i] = Convert.ToInt32(dataGridViewTable_KUE.Rows[i].Cells[columnIndex].Value);
            }


            int res = ds.SummDohod(columnData);
            textBoxOutPutData_KUE.Text = Convert.ToString(res);
        }

        private void MINSumToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnMIN_KUE.Text);

            toolStripTextBoxInputColumnMIN_KUE.Clear();

            int[] columnData = new int[dataGridViewTable_KUE.Rows.Count];

            for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
            {
                columnData[i] = Convert.ToInt32(dataGridViewTable_KUE.Rows[i].Cells[columnIndex].Value);
            }

            int res = ds.MinDohod(columnData);
            textBoxOutPutData_KUE.Text = Convert.ToString(res);
        }

        private void MAXSumToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnMAX_KUE.Text);

            toolStripTextBoxInputColumnMAX_KUE.Clear();

            int[] columnData = new int[dataGridViewTable_KUE.Rows.Count];

            for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
            {
                columnData[i] = Convert.ToInt32(dataGridViewTable_KUE.Rows[i].Cells[columnIndex].Value);
            }

            int res = ds.MaxDohod(columnData);
            textBoxOutPutData_KUE.Text = Convert.ToString(res);
        }

        private void ManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManual formManual = new FormManual();
            formManual.ShowDialog();
        }

        
    }
}
