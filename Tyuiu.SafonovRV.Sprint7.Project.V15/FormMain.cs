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

using Tyuiu.SafonovRV.Sprint7.Project.V15.Lib;

namespace Tyuiu.SafonovRV.Sprint7.Project.V15
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

        private void openToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            try
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
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewTable_KUE[j, i - 1].Value = arrayValues[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogTable_KUE.FileName = "DataBase.csv";
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
            catch
            {
                MessageBox.Show("Что-то пошло не так.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnDohod_KUE.Text);

                toolStripTextBoxInputColumnDohod_KUE.Clear();

                // Создаем массив для хранения данных из столбца
                double[] columnData = new double[dataGridViewTable_KUE.Rows.Count];

                // Используем цикл для записи данных из столбца в массив
                for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToDouble(dataGridViewTable_KUE.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.SummDohod(columnData);
                textBoxOutPutData_KUE.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MINSumToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnMIN_KUE.Text);

                toolStripTextBoxInputColumnMIN_KUE.Clear();

                double[] columnData = new double[dataGridViewTable_KUE.Rows.Count];

                for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToDouble(dataGridViewTable_KUE.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.MinDohod(columnData);
                textBoxOutPutData_KUE.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MAXSumToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnMAX_KUE.Text);

                toolStripTextBoxInputColumnMAX_KUE.Clear();

                double[] columnData = new double[dataGridViewTable_KUE.Rows.Count];

                for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToInt32(dataGridViewTable_KUE.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.MaxDohod(columnData);
                textBoxOutPutData_KUE.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AverageValueToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnAverageValue_KUE.Text);

                toolStripTextBoxInputColumnAverageValue_KUE.Clear();

                double[] columnData = new double[dataGridViewTable_KUE.Rows.Count];

                for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToInt32(dataGridViewTable_KUE.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.AverageValue(columnData);
                textBoxOutPutData_KUE.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountDocumentToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            try
            {
                int[] columnData = new int[dataGridViewTable_KUE.Rows.Count];

                for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToInt32(dataGridViewTable_KUE.Rows[i].Cells[0].Value);
                }

                int res = ds.CountDocument(columnData);
                textBoxOutPutData_KUE.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuildChartToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndexName = Convert.ToInt32(toolStripTextBoxInputColumnForChartName_KUE.Text);
                toolStripTextBoxInputColumnForChartName_KUE.Clear();

                string[] columnDataName = new string[dataGridViewTable_KUE.Rows.Count];
                for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
                {
                    columnDataName[i] = Convert.ToString(dataGridViewTable_KUE.Rows[i].Cells[columnIndexName].Value);
                }

                //

                int columnIndexData = Convert.ToInt32(toolStripTextBoxInputColumnForChartData_KUE.Text);
                toolStripTextBoxInputColumnForChartData_KUE.Clear();

                double[] columnData = new double[dataGridViewTable_KUE.Rows.Count];
                for (int i = 0; i < dataGridViewTable_KUE.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToDouble(dataGridViewTable_KUE.Rows[i].Cells[columnIndexData].Value);
                }

                DataService.ArrayData = columnData;
                DataService.ArrayName = columnDataName;

                FormChart formChart = new FormChart();
                formChart.Show();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchToolStripMenuItem_KUE_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch_KUE != null)
            {
                string currentText = toolStripTextBoxSearch_KUE.Text;
                foreach (DataGridViewRow row in dataGridViewTable_KUE.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && toolStripTextBoxSearch_KUE.Text != string.Empty && cell.Value.ToString().Contains(toolStripTextBoxSearch_KUE.Text))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void buttonUseFilter_KUE_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in dataGridViewTable_KUE.Rows)
                {
                    if ((r.Cells[comboBoxColumnForFilter_KUE.SelectedIndex].Value).ToString().ToUpper().Contains(textBoxInputFilter_KUE.Text.ToUpper()))
                    {
                        dataGridViewTable_KUE.Rows[r.Index].Visible = true;
                        dataGridViewTable_KUE.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dataGridViewTable_KUE.CurrentCell = null;
                        dataGridViewTable_KUE.Rows[r.Index].Visible = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManual formManual = new FormManual();
            formManual.Show();
        }

        
    }
}
