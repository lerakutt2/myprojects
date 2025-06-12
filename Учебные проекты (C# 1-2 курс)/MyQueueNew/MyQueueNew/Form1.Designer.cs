namespace MyQueueNew
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
            this.Capacity = new System.Windows.Forms.NumericUpDown();
            this.Create = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Peek = new System.Windows.Forms.Button();
            this.Dequeue = new System.Windows.Forms.Button();
            this.Enqueue = new System.Windows.Forms.Button();
            this.Enqueue_element = new System.Windows.Forms.TextBox();
            this.CapacityValue = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.Peek_element = new System.Windows.Forms.TextBox();
            this.Dequeue_element = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // Capacity
            // 
            this.Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capacity.Location = new System.Drawing.Point(41, 25);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(117, 30);
            this.Capacity.TabIndex = 0;
            this.Capacity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(181, 21);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(240, 37);
            this.Create.TabIndex = 1;
            this.Create.Text = "Создать очередь";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(301, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 229);
            this.listBox1.TabIndex = 2;
            // 
            // Peek
            // 
            this.Peek.Enabled = false;
            this.Peek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Peek.Location = new System.Drawing.Point(41, 170);
            this.Peek.Name = "Peek";
            this.Peek.Size = new System.Drawing.Size(117, 35);
            this.Peek.TabIndex = 3;
            this.Peek.Text = "Peek";
            this.Peek.UseVisualStyleBackColor = true;
            this.Peek.Click += new System.EventHandler(this.Peek_Click);
            // 
            // Dequeue
            // 
            this.Dequeue.Enabled = false;
            this.Dequeue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dequeue.Location = new System.Drawing.Point(41, 127);
            this.Dequeue.Name = "Dequeue";
            this.Dequeue.Size = new System.Drawing.Size(117, 37);
            this.Dequeue.TabIndex = 4;
            this.Dequeue.Text = "Dequeue";
            this.Dequeue.UseVisualStyleBackColor = true;
            this.Dequeue.Click += new System.EventHandler(this.Dequeue_Click);
            // 
            // Enqueue
            // 
            this.Enqueue.Enabled = false;
            this.Enqueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enqueue.Location = new System.Drawing.Point(41, 79);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(117, 42);
            this.Enqueue.TabIndex = 5;
            this.Enqueue.Text = "Enqueue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // Enqueue_element
            // 
            this.Enqueue_element.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enqueue_element.Location = new System.Drawing.Point(164, 85);
            this.Enqueue_element.Name = "Enqueue_element";
            this.Enqueue_element.Size = new System.Drawing.Size(100, 30);
            this.Enqueue_element.TabIndex = 6;
            // 
            // CapacityValue
            // 
            this.CapacityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapacityValue.Location = new System.Drawing.Point(164, 293);
            this.CapacityValue.Name = "CapacityValue";
            this.CapacityValue.ReadOnly = true;
            this.CapacityValue.Size = new System.Drawing.Size(100, 30);
            this.CapacityValue.TabIndex = 7;
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(164, 255);
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Size = new System.Drawing.Size(100, 30);
            this.Count.TabIndex = 8;
            // 
            // Peek_element
            // 
            this.Peek_element.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Peek_element.Location = new System.Drawing.Point(164, 172);
            this.Peek_element.Name = "Peek_element";
            this.Peek_element.ReadOnly = true;
            this.Peek_element.Size = new System.Drawing.Size(100, 30);
            this.Peek_element.TabIndex = 9;
            // 
            // Dequeue_element
            // 
            this.Dequeue_element.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dequeue_element.Location = new System.Drawing.Point(164, 130);
            this.Dequeue_element.Name = "Dequeue_element";
            this.Dequeue_element.ReadOnly = true;
            this.Dequeue_element.Size = new System.Drawing.Size(100, 30);
            this.Dequeue_element.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Capacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dequeue_element);
            this.Controls.Add(this.Peek_element);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.CapacityValue);
            this.Controls.Add(this.Enqueue_element);
            this.Controls.Add(this.Enqueue);
            this.Controls.Add(this.Dequeue);
            this.Controls.Add(this.Peek);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Capacity);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Capacity;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Peek;
        private System.Windows.Forms.Button Dequeue;
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.TextBox Enqueue_element;
        private System.Windows.Forms.TextBox CapacityValue;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox Peek_element;
        private System.Windows.Forms.TextBox Dequeue_element;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

