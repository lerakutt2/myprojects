namespace Bill
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.CreateBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bill = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(356, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(376, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(459, 346);
            this.dataGridView2.TabIndex = 1;
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(853, 92);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 35);
            this.Minus.TabIndex = 2;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(853, 133);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 35);
            this.Plus.TabIndex = 4;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // CreateBill
            // 
            this.CreateBill.Location = new System.Drawing.Point(934, 92);
            this.CreateBill.Name = "CreateBill";
            this.CreateBill.Size = new System.Drawing.Size(157, 76);
            this.CreateBill.TabIndex = 5;
            this.CreateBill.Text = "Сформировать чек";
            this.CreateBill.UseVisualStyleBackColor = true;
            this.CreateBill.Click += new System.EventHandler(this.CreateBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Чек";
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(853, 261);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(238, 177);
            this.bill.TabIndex = 7;
            this.bill.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(850, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Бюджет";
            // 
            // budget
            // 
            this.budget.Location = new System.Drawing.Point(914, 171);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(100, 22);
            this.budget.TabIndex = 9;
            this.budget.Text = "1000";
            this.budget.TextChanged += new System.EventHandler(this.Budget_TextChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(853, 199);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(226, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Стереть список покупок";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Кофейня";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateBill);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button CreateBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox bill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox budget;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label3;
    }
}

