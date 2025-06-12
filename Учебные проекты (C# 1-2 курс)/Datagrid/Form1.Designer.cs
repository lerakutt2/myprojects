namespace Datagrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteColumn = new System.Windows.Forms.Button();
            this.DeleteLine = new System.Windows.Forms.Button();
            this.ClearChart = new System.Windows.Forms.Button();
            this.AddColumn = new System.Windows.Forms.Button();
            this.AddRow = new System.Windows.Forms.Button();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yearTo = new System.Windows.Forms.TextBox();
            this.costTo = new System.Windows.Forms.TextBox();
            this.costFrom = new System.Windows.Forms.TextBox();
            this.yearFrom = new System.Windows.Forms.TextBox();
            this.costCheckBox = new System.Windows.Forms.CheckBox();
            this.yearCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(619, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.Location = new System.Drawing.Point(637, 236);
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Size = new System.Drawing.Size(151, 39);
            this.DeleteColumn.TabIndex = 1;
            this.DeleteColumn.Text = "Удалить столбец";
            this.DeleteColumn.UseVisualStyleBackColor = true;
            this.DeleteColumn.Click += new System.EventHandler(this.DeleteColumn_Click);
            // 
            // DeleteLine
            // 
            this.DeleteLine.Location = new System.Drawing.Point(637, 191);
            this.DeleteLine.Name = "DeleteLine";
            this.DeleteLine.Size = new System.Drawing.Size(151, 39);
            this.DeleteLine.TabIndex = 2;
            this.DeleteLine.Text = "Удалить строку";
            this.DeleteLine.UseVisualStyleBackColor = true;
            this.DeleteLine.Click += new System.EventHandler(this.DeleteLine_Click);
            // 
            // ClearChart
            // 
            this.ClearChart.Location = new System.Drawing.Point(637, 390);
            this.ClearChart.Name = "ClearChart";
            this.ClearChart.Size = new System.Drawing.Size(151, 39);
            this.ClearChart.TabIndex = 3;
            this.ClearChart.Text = "Очистить таблицу";
            this.ClearChart.UseVisualStyleBackColor = true;
            this.ClearChart.Click += new System.EventHandler(this.ClearChart_Click);
            // 
            // AddColumn
            // 
            this.AddColumn.Location = new System.Drawing.Point(637, 281);
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.Size = new System.Drawing.Size(151, 39);
            this.AddColumn.TabIndex = 4;
            this.AddColumn.Text = "Добавить столбец";
            this.AddColumn.UseVisualStyleBackColor = true;
            this.AddColumn.Click += new System.EventHandler(this.AddColumn_Click);
            // 
            // AddRow
            // 
            this.AddRow.Location = new System.Drawing.Point(637, 146);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(151, 39);
            this.AddRow.TabIndex = 5;
            this.AddRow.Text = "Добавить строку";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(51, 16);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 22);
            this.NametextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 16);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Имя";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(637, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 54);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yearTo);
            this.groupBox2.Controls.Add(this.costTo);
            this.groupBox2.Controls.Add(this.costFrom);
            this.groupBox2.Controls.Add(this.yearFrom);
            this.groupBox2.Controls.Add(this.costCheckBox);
            this.groupBox2.Controls.Add(this.yearCheckBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(438, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 128);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтрация";
            // 
            // yearTo
            // 
            this.yearTo.Location = new System.Drawing.Point(208, 25);
            this.yearTo.Name = "yearTo";
            this.yearTo.Size = new System.Drawing.Size(73, 22);
            this.yearTo.TabIndex = 13;
            this.yearTo.TextChanged += new System.EventHandler(this.yearTo_TextChanged);
            // 
            // costTo
            // 
            this.costTo.Location = new System.Drawing.Point(206, 67);
            this.costTo.Name = "costTo";
            this.costTo.Size = new System.Drawing.Size(73, 22);
            this.costTo.TabIndex = 12;
            this.costTo.TextChanged += new System.EventHandler(this.costTo_TextChanged);
            // 
            // costFrom
            // 
            this.costFrom.Location = new System.Drawing.Point(98, 64);
            this.costFrom.Name = "costFrom";
            this.costFrom.Size = new System.Drawing.Size(73, 22);
            this.costFrom.TabIndex = 11;
            this.costFrom.TextChanged += new System.EventHandler(this.costFrom_TextChanged);
            // 
            // yearFrom
            // 
            this.yearFrom.Location = new System.Drawing.Point(98, 22);
            this.yearFrom.Name = "yearFrom";
            this.yearFrom.Size = new System.Drawing.Size(73, 22);
            this.yearFrom.TabIndex = 10;
            this.yearFrom.TextChanged += new System.EventHandler(this.yearFrom_TextChanged);
            // 
            // costCheckBox
            // 
            this.costCheckBox.AutoSize = true;
            this.costCheckBox.Location = new System.Drawing.Point(6, 66);
            this.costCheckBox.Name = "costCheckBox";
            this.costCheckBox.Size = new System.Drawing.Size(61, 20);
            this.costCheckBox.TabIndex = 9;
            this.costCheckBox.Text = "цена";
            this.costCheckBox.UseVisualStyleBackColor = true;
            this.costCheckBox.CheckedChanged += new System.EventHandler(this.costCheckBox_CheckedChanged);
            // 
            // yearCheckBox
            // 
            this.yearCheckBox.AutoSize = true;
            this.yearCheckBox.Location = new System.Drawing.Point(6, 25);
            this.yearCheckBox.Name = "yearCheckBox";
            this.yearCheckBox.Size = new System.Drawing.Size(51, 20);
            this.yearCheckBox.TabIndex = 8;
            this.yearCheckBox.Text = "год";
            this.yearCheckBox.UseVisualStyleBackColor = true;
            this.yearCheckBox.CheckedChanged += new System.EventHandler(this.yearCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "от";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "от";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 78);
            this.label5.TabIndex = 10;
            this.label5.Text = "Магазин\r\nАнтиквариата\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AddRow);
            this.Controls.Add(this.AddColumn);
            this.Controls.Add(this.ClearChart);
            this.Controls.Add(this.DeleteLine);
            this.Controls.Add(this.DeleteColumn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteColumn;
        private System.Windows.Forms.Button DeleteLine;
        private System.Windows.Forms.Button ClearChart;
        private System.Windows.Forms.Button AddColumn;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox costCheckBox;
        private System.Windows.Forms.CheckBox yearCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yearTo;
        private System.Windows.Forms.TextBox costTo;
        private System.Windows.Forms.TextBox costFrom;
        private System.Windows.Forms.TextBox yearFrom;
        private System.Windows.Forms.Label label5;
    }
}

