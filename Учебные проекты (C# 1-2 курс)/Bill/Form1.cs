using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = List.items;
            dataGridView1.Columns.Remove("amount");
            dataGridView1.CellClick += DataGridView1_CellClick;
        }
        /// <summary>
        /// Добавляем товары из одного списка в другой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool b = true;
            foreach (Item item in List.purchases)
            {
                if (item.name == List.items[e.RowIndex].name) // увеличиваем количество если пользователь кликнул второй раз
                {
                    item.amount++;
                    b = false;
                    break;
                }
            }
            if (b) List.purchases.Add(new Item(List.items[e.RowIndex])); // если пользователь кликнул первый раз
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = List.purchases;
        }

        /// <summary>
        /// Уменьшает количество выбранного товара в списке покупок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minus_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                List.purchases[dataGridView2.SelectedCells[0].RowIndex].amount--;
                if (List.purchases[dataGridView2.SelectedCells[0].RowIndex].amount == 0)
                {
                    List.purchases.RemoveAt(dataGridView2.SelectedCells[0].RowIndex);
                }
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = List.purchases;
            }
        }

        /// <summary>
        /// Увеличивает количество выбранного товара в списке покупок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plus_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                List.purchases[dataGridView2.SelectedCells[0].RowIndex].amount++;
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = List.purchases;
            }
        }

        /// <summary>
        /// Печатает чек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateBill_Click(object sender, EventArgs e)
        {
            int cost = 0;
            bill.Clear();
            foreach(Item item in List.purchases)
            {
                bill.Text += item.name + ", " + item.cost + " руб., " + item.amount + " шт.\n";
                cost += item.cost * item.amount;
            }

            if (Convert.ToInt32(budget.Text) - cost >= 0)
            {
                bill.Text += "Итого: " + cost.ToString() + " руб.";
                budget.Text = (Convert.ToInt32(budget.Text) - cost).ToString();
                MessageBox.Show("Итого: " + cost + "\nОстаток: " + budget.Text);
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
                bill.Clear();
            }
            List.purchases.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = List.purchases;
        }

        private void Budget_TextChanged(object sender, EventArgs e)
        {
            if (!budget.Text.All(char.IsDigit))
            {
                MessageBox.Show("Это поле может содержать только цифры");
                budget.Text = "1000";
            }
        }

        /// <summary>
        /// Стирает список покупок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            List.purchases.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = List.purchases;
        }

    }
}
