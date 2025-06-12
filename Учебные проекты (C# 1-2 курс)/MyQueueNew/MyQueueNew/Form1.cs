using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQueueNew
{
    public partial class Form1 : Form
    {
        MyQueue<int> queue;
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateQueue()
        {
            listBox1.Items.Clear();
            int[] currentData = queue.ToArray();
            for (int i = 0; i < currentData.Length; i++)
            {
                listBox1.Items.Add(currentData[i]);
            }
            Count.Text = queue.Count.ToString();
            CapacityValue.Text = queue.Capacity.ToString();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            queue = new MyQueue<int>(Convert.ToInt16(Capacity.Value));
            Enqueue.Enabled = true;
            Dequeue.Enabled = true;
            Peek.Enabled = true;
        }

        private void Enqueue_Click(object sender, EventArgs e)
        {
            try
            {
                queue.Enqueue(Convert.ToInt32(Enqueue_element.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы можете добавить в очередь только целое число");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Очередь заполнена");
            }

            UpdateQueue();
        }

        private void Dequeue_Click(object sender, EventArgs e)
        {
            try
            {
                Dequeue_element.Text = queue.Dequeue().ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Элементов нет");
            }

            UpdateQueue();
        }

        private void Peek_Click(object sender, EventArgs e)
        {
            try
            {
                Peek_element.Text = queue.Peek().ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Элементов нет");
            }

            UpdateQueue();
        }
    }
}
