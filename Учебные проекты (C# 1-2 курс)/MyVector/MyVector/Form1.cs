using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVector
{
    public partial class Form1 : Form
    {
        MyVector<int> vector;
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateVector()
        {
            // Вывод данных, обращаясь по индексу
            listBox1.Items.Clear();
            for (int i = 0; i < vector.Size; i++)
            {
                listBox1.Items.Add(vector[i]);
            }

            // Вывод данных с помощью ToArray
            listBox2.Items.Clear();
            int[] array = vector.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
              listBox2.Items.Add(array[i]);
            }

            // Вывод данных через foreach
            listBox3.Items.Clear();
            foreach (var item in vector)
            {
                listBox3.Items.Add(item);
            }            
            
            // Вывод Capacity и Size
            SizeValue.Text = vector.Size.ToString();
            CapacityValue.Text = vector.Capacity.ToString();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            vector = new MyVector<int>(Convert.ToInt16(Capacity.Value));
            Add.Enabled = true;
            Resize_button.Enabled = true;
            Reserve.Enabled = true;
            ShrinkToFit.Enabled = true;
            SetValue.Enabled = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                vector.Add(Convert.ToInt16(ElementToAdd.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Элемент должен быть целым числом");
            }
            UpdateVector();
        }

        private void Resize_button_Click(object sender, EventArgs e)
        {
            try
            {
                vector.Resize(Convert.ToInt16(newSize.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Элемент должен быть целым числом");
            }
            UpdateVector();
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            try
            {
                vector.Reserve(Convert.ToInt16(newCapacity.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Элемент должен быть целым числом");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Вы можете только увеличивать размер");
            }
            UpdateVector();
        }

        private void ShrinkToFit_Click(object sender, EventArgs e)
        {
            vector.ShrinkToFit();
            UpdateVector();
        }

        private void SetValue_Click(object sender, EventArgs e)
        {
            try
            {
                vector.SetValue(Convert.ToInt16(Index.Text), Convert.ToInt16(ValueAtIndex.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Элемент должен быть целым числом");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Индекс за пределами диапазона");
            }
            UpdateVector();
        }
    }
}
