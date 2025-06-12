using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyList
{
    public partial class Form1 : Form
    {
        readonly MyList<string> list = new MyList<string>();
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateList()
        {
            listBox1.Items.Clear();
            string[] array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                listBox1.Items.Add(array[i]);
            }

            listBox2.Items.Clear();
            for (int i = 0; i < list.Size; i++)
            {
                listBox2.Items.Add(array[i]);
            }

            listBox3.Items.Clear();
            if (list.Size != 0)
            {
                foreach (var item in list)
                {
                    listBox3.Items.Add(item);
                }
            }
        }

        void EnableButtons()
        {
            Insert.Enabled = true;
            Remove.Enabled = true;
            RemoveAt.Enabled = true;
            At.Enabled = true;
            SetValue.Enabled = true;
            ContainsButton.Enabled = true;
            Find.Enabled = true;
        }

        private void Prepend_Click(object sender, EventArgs e)
        {
            list.Prepend(NewFirst.Text);
            UpdateList();
            if (!Insert.Enabled) EnableButtons();
        }

        private void Append_Click(object sender, EventArgs e)
        {
            list.Append(NewLast.Text);
            UpdateList();
            if (!Insert.Enabled) EnableButtons();

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                list.Insert(Convert.ToInt16(Index.Text), Value.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Индекс должен быть целым числом");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Индекс за пределами диапазона");
            }
            UpdateList();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            bool exsists = list.Remove(ElementToRemove.Text);
            if (!exsists)
            {
                MessageBox.Show("Элемент не найден");
            }
            UpdateList();
        }

        private void RemoveAt_Click(object sender, EventArgs e)
        {
            try
            {
                list.RemoveAt(Convert.ToInt16(IndexToRemove.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Индекс должен быть целым числом");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Индекс за пределами диапазона");
            }
            UpdateList();
        }

        private void At_Click(object sender, EventArgs e)
        {
            try
            {
                ValueAt.Text = list.At(Convert.ToInt16(AtIndex.Text)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы можете ввести только целое число");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Индекс за пределами диапазона");
            }
            UpdateList();
        }

        private void SetValue_Click(object sender, EventArgs e)
        {
            try
            {
                list.SetValue(Convert.ToInt16(SetIndex.Text), ValueToSet.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Индекс должен быть целым положительным числом");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Индекс за пределами диапазона");
            }
            UpdateList();
        }

        private void Contains_Click(object sender, EventArgs e)
        {
            bool b = list.Contains(ContainsValue.Text);

            if (b)
            {
                ContainsAnswer.Text = "есть";
            }
            else
            {
                ContainsAnswer.Text = "нет";
            }
            UpdateList();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            int index = list.Find(ValueToFind.Text);

            if (index < list.Size)
            {
                IndexFound.Text = index.ToString();
            }
            else
            {
                IndexFound.Text = "нет";
            }
            UpdateList();
        }
    }
}
