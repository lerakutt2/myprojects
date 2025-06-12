namespace MyList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NewFirst = new System.Windows.Forms.TextBox();
            this.Prepend = new System.Windows.Forms.Button();
            this.Append = new System.Windows.Forms.Button();
            this.NewLast = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.Index = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ElementToRemove = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IndexToRemove = new System.Windows.Forms.TextBox();
            this.RemoveAt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AtIndex = new System.Windows.Forms.TextBox();
            this.ValueAt = new System.Windows.Forms.TextBox();
            this.At = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SetIndex = new System.Windows.Forms.TextBox();
            this.ValueToSet = new System.Windows.Forms.TextBox();
            this.SetValue = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.ContainsButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ContainsAnswer = new System.Windows.Forms.TextBox();
            this.ContainsValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.IndexFound = new System.Windows.Forms.TextBox();
            this.ValueToFind = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(468, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 554);
            this.listBox1.TabIndex = 0;
            // 
            // NewFirst
            // 
            this.NewFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewFirst.Location = new System.Drawing.Point(267, 38);
            this.NewFirst.Name = "NewFirst";
            this.NewFirst.Size = new System.Drawing.Size(100, 30);
            this.NewFirst.TabIndex = 1;
            this.NewFirst.Text = "1";
            // 
            // Prepend
            // 
            this.Prepend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prepend.Location = new System.Drawing.Point(12, 34);
            this.Prepend.Name = "Prepend";
            this.Prepend.Size = new System.Drawing.Size(244, 39);
            this.Prepend.TabIndex = 2;
            this.Prepend.Text = "Добавить в начало";
            this.Prepend.UseVisualStyleBackColor = true;
            this.Prepend.Click += new System.EventHandler(this.Prepend_Click);
            // 
            // Append
            // 
            this.Append.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Append.Location = new System.Drawing.Point(12, 79);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(244, 38);
            this.Append.TabIndex = 4;
            this.Append.Text = "Добавить в конец";
            this.Append.UseVisualStyleBackColor = true;
            this.Append.Click += new System.EventHandler(this.Append_Click);
            // 
            // NewLast
            // 
            this.NewLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLast.Location = new System.Drawing.Point(267, 83);
            this.NewLast.Name = "NewLast";
            this.NewLast.Size = new System.Drawing.Size(100, 30);
            this.NewLast.TabIndex = 3;
            this.NewLast.Text = "2";
            // 
            // Insert
            // 
            this.Insert.Enabled = false;
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Insert.Location = new System.Drawing.Point(12, 123);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(244, 54);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Вставить";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Value
            // 
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Value.Location = new System.Drawing.Point(355, 144);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(90, 30);
            this.Value.TabIndex = 6;
            this.Value.Text = "7";
            // 
            // Index
            // 
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Index.Location = new System.Drawing.Point(267, 144);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(59, 30);
            this.Index.TabIndex = 7;
            this.Index.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "индекс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(346, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "значение";
            // 
            // Remove
            // 
            this.Remove.Enabled = false;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remove.Location = new System.Drawing.Point(12, 183);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(244, 66);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "Удалить по значению";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "значение";
            // 
            // ElementToRemove
            // 
            this.ElementToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementToRemove.Location = new System.Drawing.Point(280, 215);
            this.ElementToRemove.Name = "ElementToRemove";
            this.ElementToRemove.Size = new System.Drawing.Size(59, 30);
            this.ElementToRemove.TabIndex = 11;
            this.ElementToRemove.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(273, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "индекс";
            // 
            // IndexToRemove
            // 
            this.IndexToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexToRemove.Location = new System.Drawing.Point(278, 280);
            this.IndexToRemove.Name = "IndexToRemove";
            this.IndexToRemove.Size = new System.Drawing.Size(59, 30);
            this.IndexToRemove.TabIndex = 15;
            this.IndexToRemove.Text = "2";
            // 
            // RemoveAt
            // 
            this.RemoveAt.Enabled = false;
            this.RemoveAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveAt.Location = new System.Drawing.Point(12, 255);
            this.RemoveAt.Name = "RemoveAt";
            this.RemoveAt.Size = new System.Drawing.Size(244, 55);
            this.RemoveAt.TabIndex = 13;
            this.RemoveAt.Text = "Удалить по индексу";
            this.RemoveAt.UseVisualStyleBackColor = true;
            this.RemoveAt.Click += new System.EventHandler(this.RemoveAt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(350, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "значение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(260, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "индекс";
            // 
            // AtIndex
            // 
            this.AtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AtIndex.Location = new System.Drawing.Point(267, 344);
            this.AtIndex.Name = "AtIndex";
            this.AtIndex.Size = new System.Drawing.Size(59, 30);
            this.AtIndex.TabIndex = 19;
            this.AtIndex.Text = "2";
            // 
            // ValueAt
            // 
            this.ValueAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueAt.Location = new System.Drawing.Point(355, 344);
            this.ValueAt.Name = "ValueAt";
            this.ValueAt.ReadOnly = true;
            this.ValueAt.Size = new System.Drawing.Size(90, 30);
            this.ValueAt.TabIndex = 18;
            // 
            // At
            // 
            this.At.Enabled = false;
            this.At.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.At.Location = new System.Drawing.Point(12, 316);
            this.At.Name = "At";
            this.At.Size = new System.Drawing.Size(242, 55);
            this.At.TabIndex = 17;
            this.At.Text = "Значение по индексу";
            this.At.UseVisualStyleBackColor = true;
            this.At.Click += new System.EventHandler(this.At_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(350, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "значение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(262, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "индекс";
            // 
            // SetIndex
            // 
            this.SetIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetIndex.Location = new System.Drawing.Point(267, 412);
            this.SetIndex.Name = "SetIndex";
            this.SetIndex.Size = new System.Drawing.Size(59, 30);
            this.SetIndex.TabIndex = 24;
            this.SetIndex.Text = "2";
            // 
            // ValueToSet
            // 
            this.ValueToSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueToSet.Location = new System.Drawing.Point(355, 412);
            this.ValueToSet.Name = "ValueToSet";
            this.ValueToSet.Size = new System.Drawing.Size(90, 30);
            this.ValueToSet.TabIndex = 23;
            this.ValueToSet.Text = "7";
            // 
            // SetValue
            // 
            this.SetValue.Enabled = false;
            this.SetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetValue.Location = new System.Drawing.Point(12, 385);
            this.SetValue.Name = "SetValue";
            this.SetValue.Size = new System.Drawing.Size(242, 84);
            this.SetValue.TabIndex = 22;
            this.SetValue.Text = "Изменить значение по индексу";
            this.SetValue.UseVisualStyleBackColor = true;
            this.SetValue.Click += new System.EventHandler(this.SetValue_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(150, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Двусвязный список";
            // 
            // Find
            // 
            this.Find.Enabled = false;
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find.Location = new System.Drawing.Point(14, 531);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(242, 51);
            this.Find.TabIndex = 28;
            this.Find.Text = "Найти";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // ContainsButton
            // 
            this.ContainsButton.Enabled = false;
            this.ContainsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainsButton.Location = new System.Drawing.Point(14, 475);
            this.ContainsButton.Name = "ContainsButton";
            this.ContainsButton.Size = new System.Drawing.Size(242, 50);
            this.ContainsButton.TabIndex = 29;
            this.ContainsButton.Text = "Есть ли в списке?";
            this.ContainsButton.UseVisualStyleBackColor = true;
            this.ContainsButton.Click += new System.EventHandler(this.Contains_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(262, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "значение";
            // 
            // ContainsAnswer
            // 
            this.ContainsAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainsAnswer.Location = new System.Drawing.Point(367, 485);
            this.ContainsAnswer.Name = "ContainsAnswer";
            this.ContainsAnswer.ReadOnly = true;
            this.ContainsAnswer.Size = new System.Drawing.Size(78, 30);
            this.ContainsAnswer.TabIndex = 31;
            // 
            // ContainsValue
            // 
            this.ContainsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainsValue.Location = new System.Drawing.Point(267, 485);
            this.ContainsValue.Name = "ContainsValue";
            this.ContainsValue.Size = new System.Drawing.Size(90, 30);
            this.ContainsValue.TabIndex = 30;
            this.ContainsValue.Text = "7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(262, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "значение";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(373, 518);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "индекс";
            // 
            // IndexFound
            // 
            this.IndexFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexFound.Location = new System.Drawing.Point(378, 546);
            this.IndexFound.Name = "IndexFound";
            this.IndexFound.ReadOnly = true;
            this.IndexFound.Size = new System.Drawing.Size(59, 30);
            this.IndexFound.TabIndex = 35;
            // 
            // ValueToFind
            // 
            this.ValueToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueToFind.Location = new System.Drawing.Point(267, 546);
            this.ValueToFind.Name = "ValueToFind";
            this.ValueToFind.Size = new System.Drawing.Size(90, 30);
            this.ValueToFind.TabIndex = 34;
            this.ValueToFind.Text = "7";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(596, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 554);
            this.listBox2.TabIndex = 38;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(722, 28);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 554);
            this.listBox3.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(468, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "ToArray()";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(719, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "foreach";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(593, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "индексатор";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 600);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.IndexFound);
            this.Controls.Add(this.ValueToFind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ContainsAnswer);
            this.Controls.Add(this.ContainsValue);
            this.Controls.Add(this.ContainsButton);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SetIndex);
            this.Controls.Add(this.ValueToSet);
            this.Controls.Add(this.SetValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AtIndex);
            this.Controls.Add(this.ValueAt);
            this.Controls.Add(this.At);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IndexToRemove);
            this.Controls.Add(this.RemoveAt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ElementToRemove);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Append);
            this.Controls.Add(this.NewLast);
            this.Controls.Add(this.Prepend);
            this.Controls.Add(this.NewFirst);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox NewFirst;
        private System.Windows.Forms.Button Prepend;
        private System.Windows.Forms.Button Append;
        private System.Windows.Forms.TextBox NewLast;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox Index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ElementToRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IndexToRemove;
        private System.Windows.Forms.Button RemoveAt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AtIndex;
        private System.Windows.Forms.TextBox ValueAt;
        private System.Windows.Forms.Button At;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SetIndex;
        private System.Windows.Forms.TextBox ValueToSet;
        private System.Windows.Forms.Button SetValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button ContainsButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ContainsAnswer;
        private System.Windows.Forms.TextBox ContainsValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IndexFound;
        private System.Windows.Forms.TextBox ValueToFind;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

