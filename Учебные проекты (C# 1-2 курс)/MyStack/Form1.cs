using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyStack<int> stack = new MyStack<int>(0);

        private void Create_Click(object sender, EventArgs e)
        {
            stack = new MyStack<int>(Convert.ToInt16(Capacity.Value));
            UpdateList();
        }

        void UpdateList() 
        {
            listBox1.Items.Clear();
            int[] currentData = stack.CurrentData();
            for (int i = currentData.Length - 1; i >= 0; i--)
            {
                listBox1.Items.Add(currentData[i]);
            }
            Count.Text = currentData.Length.ToString();
            CapacityValue.Text = stack.Capacity.ToString();
        }

        private void Push_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Push(Convert.ToInt32(PushElement.Text));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Попытка выйти за границы стэка");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
            UpdateList();
        }

        private void Pop_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Pop();
            }
            catch
            {
                MessageBox.Show("Элементов больше нет");
            }
            UpdateList();
        }

        private void Top_Click(object sender, EventArgs e)
        {
            try
            {
                TopElement.Text = stack.Top().ToString();
            }
            catch
            {
                MessageBox.Show("Элементы отсутствуют");
            }
        }
    }
}
