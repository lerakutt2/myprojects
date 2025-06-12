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
using static System.Windows.Forms.LinkLabel;

namespace Datagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("file.txt"); // Метод считывания с файла с товарами
            
            // Добавление столбцов
            dataGridView1.Columns.Add("name", "Название");
            dataGridView1.Columns.Add("year", "Год выпуска");
            dataGridView1.Columns.Add("cost", "Цена, руб.");

            int linesCount = lines.Length / dataGridView1.Columns.Count;
            int columnCount = dataGridView1.Columns.Count; 

            int sum = 0;
            for (int j = 0; j < linesCount; j++)
            {               
                dataGridView1.Rows.Add(); // добавление строки 

                for (int i = 0; i < columnCount; i++)
                {
                    try
                    {
                        dataGridView1.Rows[j].Cells[i].Value = lines[sum];
                        sum++;
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }
            }

            // изначальный текст фильтров
            yearTo.Text = "2023";
            yearFrom.Text = "1800";
            costFrom.Text = "0";
            costTo.Text = "1000000";

            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        /// <summary>
        /// Проверяет правильность написанного в клетках
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (!dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().All(char.IsDigit))
                {
                    MessageBox.Show("Это поле может содержать только цифры");
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                }
            }
        }

        /// <summary>
        /// Удаляет столбец
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteColumn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                dataGridView1.Columns.Remove(dataGridView1.SelectedCells[i].OwningColumn.Name);
            }
        }

        /// <summary>
        /// Удаляет строку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteLine_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedCells[i].OwningRow);
            }
        }

        /// <summary>
        /// Очищает таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearChart_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        /// <summary>
        /// Добавляет столбец с определенным или пустым названием
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddColumn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("column" + dataGridView1.ColumnCount.ToString(), NametextBox.Text);
        }

        /// <summary>
        /// Добавляет строку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        /// <summary>
        /// Происходит при включении фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }
        /// <summary>
        /// Происходит при включении фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void costCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }


        private void Filter()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (costCheckBox.Checked && yearCheckBox.Checked)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) <= Convert.ToInt32(costFrom.Text)
                        || Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) >= Convert.ToInt32(costTo.Text))
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) <= Convert.ToInt32(yearFrom.Text)
                        || Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) >= Convert.ToInt32(yearTo.Text))
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
                else if (yearCheckBox.Checked)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > Convert.ToInt32(yearFrom.Text)
                        && Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < Convert.ToInt32(yearTo.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
                else if (costCheckBox.Checked)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) > Convert.ToInt32(costFrom.Text)
                        && Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) < Convert.ToInt32(costTo.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
                else
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }
        }

        // События происходят при изменении значений фильтрации
        private void yearFrom_TextChanged(object sender, EventArgs e)
        {
            if (yearCheckBox.Checked && yearFrom.Text != "")
            {
                Filter();
            }
        }

        private void yearTo_TextChanged(object sender, EventArgs e)
        {
            if (yearCheckBox.Checked && yearTo.Text != "")
            {
                Filter();
            }
        }

        private void costFrom_TextChanged(object sender, EventArgs e)
        {
            if (costCheckBox.Checked && costFrom.Text != "")
            {
                Filter();
            }
        }

        private void costTo_TextChanged(object sender, EventArgs e)
        {
            if (costCheckBox.Checked && costTo.Text != "")
            {
                Filter();
            }
        }
    }
}
