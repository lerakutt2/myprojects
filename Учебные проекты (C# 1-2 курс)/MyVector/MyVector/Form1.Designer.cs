namespace MyVector
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create = new System.Windows.Forms.Button();
            this.Capacity = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Resize_button = new System.Windows.Forms.Button();
            this.ShrinkToFit = new System.Windows.Forms.Button();
            this.Reserve = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ElementToAdd = new System.Windows.Forms.TextBox();
            this.newSize = new System.Windows.Forms.TextBox();
            this.newCapacity = new System.Windows.Forms.TextBox();
            this.SetValue = new System.Windows.Forms.Button();
            this.ValueAtIndex = new System.Windows.Forms.TextBox();
            this.Index = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SizeValue = new System.Windows.Forms.TextBox();
            this.CapacityValue = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(175, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(143, 30);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать вектор";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Capacity
            // 
            this.Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capacity.Location = new System.Drawing.Point(12, 12);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(157, 30);
            this.Capacity.TabIndex = 1;
            this.Capacity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(338, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 354);
            this.listBox1.TabIndex = 2;
            // 
            // Resize_button
            // 
            this.Resize_button.Enabled = false;
            this.Resize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resize_button.Location = new System.Drawing.Point(12, 91);
            this.Resize_button.Name = "Resize_button";
            this.Resize_button.Size = new System.Drawing.Size(157, 37);
            this.Resize_button.TabIndex = 3;
            this.Resize_button.Text = "Resize";
            this.Resize_button.UseVisualStyleBackColor = true;
            this.Resize_button.Click += new System.EventHandler(this.Resize_button_Click);
            // 
            // ShrinkToFit
            // 
            this.ShrinkToFit.Enabled = false;
            this.ShrinkToFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShrinkToFit.Location = new System.Drawing.Point(90, 177);
            this.ShrinkToFit.Name = "ShrinkToFit";
            this.ShrinkToFit.Size = new System.Drawing.Size(157, 37);
            this.ShrinkToFit.TabIndex = 6;
            this.ShrinkToFit.Text = "ShrinkToFit";
            this.ShrinkToFit.UseVisualStyleBackColor = true;
            this.ShrinkToFit.Click += new System.EventHandler(this.ShrinkToFit_Click);
            // 
            // Reserve
            // 
            this.Reserve.Enabled = false;
            this.Reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reserve.Location = new System.Drawing.Point(12, 134);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(157, 37);
            this.Reserve.TabIndex = 7;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // Add
            // 
            this.Add.Enabled = false;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(12, 48);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(157, 37);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ElementToAdd
            // 
            this.ElementToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementToAdd.Location = new System.Drawing.Point(175, 51);
            this.ElementToAdd.Name = "ElementToAdd";
            this.ElementToAdd.Size = new System.Drawing.Size(143, 30);
            this.ElementToAdd.TabIndex = 9;
            this.ElementToAdd.Text = "1";
            // 
            // newSize
            // 
            this.newSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newSize.Location = new System.Drawing.Point(175, 94);
            this.newSize.Name = "newSize";
            this.newSize.Size = new System.Drawing.Size(143, 30);
            this.newSize.TabIndex = 10;
            this.newSize.Text = "2";
            // 
            // newCapacity
            // 
            this.newCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newCapacity.Location = new System.Drawing.Point(175, 137);
            this.newCapacity.Name = "newCapacity";
            this.newCapacity.Size = new System.Drawing.Size(143, 30);
            this.newCapacity.TabIndex = 11;
            this.newCapacity.Text = "5";
            // 
            // SetValue
            // 
            this.SetValue.Enabled = false;
            this.SetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetValue.Location = new System.Drawing.Point(12, 242);
            this.SetValue.Name = "SetValue";
            this.SetValue.Size = new System.Drawing.Size(157, 37);
            this.SetValue.TabIndex = 5;
            this.SetValue.Text = "SetValue";
            this.SetValue.UseVisualStyleBackColor = true;
            this.SetValue.Click += new System.EventHandler(this.SetValue_Click);
            // 
            // ValueAtIndex
            // 
            this.ValueAtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueAtIndex.Location = new System.Drawing.Point(253, 245);
            this.ValueAtIndex.Name = "ValueAtIndex";
            this.ValueAtIndex.Size = new System.Drawing.Size(79, 30);
            this.ValueAtIndex.TabIndex = 12;
            this.ValueAtIndex.Text = "5";
            // 
            // Index
            // 
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Index.Location = new System.Drawing.Point(175, 245);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(72, 30);
            this.Index.TabIndex = 13;
            this.Index.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(80, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(118, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Size";
            // 
            // SizeValue
            // 
            this.SizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeValue.Location = new System.Drawing.Point(175, 327);
            this.SizeValue.Name = "SizeValue";
            this.SizeValue.ReadOnly = true;
            this.SizeValue.Size = new System.Drawing.Size(143, 30);
            this.SizeValue.TabIndex = 18;
            // 
            // CapacityValue
            // 
            this.CapacityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapacityValue.Location = new System.Drawing.Point(175, 291);
            this.CapacityValue.Name = "CapacityValue";
            this.CapacityValue.ReadOnly = true;
            this.CapacityValue.Size = new System.Drawing.Size(143, 30);
            this.CapacityValue.TabIndex = 19;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(464, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 354);
            this.listBox2.TabIndex = 20;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(590, 30);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 354);
            this.listBox3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Вывод по индексу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Вывод через foreach";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "через ToArray";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 396);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.CapacityValue);
            this.Controls.Add(this.SizeValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.ValueAtIndex);
            this.Controls.Add(this.newCapacity);
            this.Controls.Add(this.newSize);
            this.Controls.Add(this.ElementToAdd);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Reserve);
            this.Controls.Add(this.ShrinkToFit);
            this.Controls.Add(this.SetValue);
            this.Controls.Add(this.Resize_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.NumericUpDown Capacity;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Resize_button;
        private System.Windows.Forms.Button ShrinkToFit;
        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox ElementToAdd;
        private System.Windows.Forms.TextBox newSize;
        private System.Windows.Forms.TextBox newCapacity;
        private System.Windows.Forms.Button SetValue;
        private System.Windows.Forms.TextBox ValueAtIndex;
        private System.Windows.Forms.TextBox Index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SizeValue;
        private System.Windows.Forms.TextBox CapacityValue;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

