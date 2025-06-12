namespace MyStack
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
            this.Capacity = new System.Windows.Forms.NumericUpDown();
            this.Create = new System.Windows.Forms.Button();
            this.Push = new System.Windows.Forms.Button();
            this.Pop = new System.Windows.Forms.Button();
            this.Top_Button = new System.Windows.Forms.Button();
            this.PushElement = new System.Windows.Forms.TextBox();
            this.TopElement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.CapacityValue = new System.Windows.Forms.TextBox();
            this.cap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(338, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 292);
            this.listBox1.TabIndex = 0;
            // 
            // Capacity
            // 
            this.Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capacity.Location = new System.Drawing.Point(199, 19);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(120, 30);
            this.Capacity.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(10, 4);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(183, 59);
            this.Create.TabIndex = 2;
            this.Create.Text = "Создать стек";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Push
            // 
            this.Push.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Push.Location = new System.Drawing.Point(59, 88);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(75, 45);
            this.Push.TabIndex = 3;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = true;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // Pop
            // 
            this.Pop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pop.Location = new System.Drawing.Point(117, 186);
            this.Pop.Name = "Pop";
            this.Pop.Size = new System.Drawing.Size(75, 43);
            this.Pop.TabIndex = 4;
            this.Pop.Text = "Pop";
            this.Pop.UseVisualStyleBackColor = true;
            this.Pop.Click += new System.EventHandler(this.Pop_Click);
            // 
            // Top_Button
            // 
            this.Top_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Top_Button.Location = new System.Drawing.Point(59, 139);
            this.Top_Button.Name = "Top_Button";
            this.Top_Button.Size = new System.Drawing.Size(75, 41);
            this.Top_Button.TabIndex = 5;
            this.Top_Button.Text = "Top";
            this.Top_Button.UseVisualStyleBackColor = true;
            this.Top_Button.Click += new System.EventHandler(this.Top_Click);
            // 
            // PushElement
            // 
            this.PushElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PushElement.Location = new System.Drawing.Point(140, 95);
            this.PushElement.Name = "PushElement";
            this.PushElement.Size = new System.Drawing.Size(117, 30);
            this.PushElement.TabIndex = 6;
            // 
            // TopElement
            // 
            this.TopElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopElement.Location = new System.Drawing.Point(140, 144);
            this.TopElement.Name = "TopElement";
            this.TopElement.ReadOnly = true;
            this.TopElement.Size = new System.Drawing.Size(117, 30);
            this.TopElement.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Count";
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(186, 238);
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Size = new System.Drawing.Size(100, 30);
            this.Count.TabIndex = 10;
            // 
            // CapacityValue
            // 
            this.CapacityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapacityValue.Location = new System.Drawing.Point(186, 279);
            this.CapacityValue.Name = "CapacityValue";
            this.CapacityValue.ReadOnly = true;
            this.CapacityValue.Size = new System.Drawing.Size(100, 30);
            this.CapacityValue.TabIndex = 11;
            // 
            // cap
            // 
            this.cap.AutoSize = true;
            this.cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cap.Location = new System.Drawing.Point(26, 279);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(145, 25);
            this.cap.TabIndex = 12;
            this.cap.Text = "Вместимость";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 339);
            this.Controls.Add(this.cap);
            this.Controls.Add(this.CapacityValue);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopElement);
            this.Controls.Add(this.PushElement);
            this.Controls.Add(this.Top_Button);
            this.Controls.Add(this.Pop);
            this.Controls.Add(this.Push);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown Capacity;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.Button Pop;
        private System.Windows.Forms.Button Top_Button;
        private System.Windows.Forms.TextBox PushElement;
        private System.Windows.Forms.TextBox TopElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox CapacityValue;
        private System.Windows.Forms.Label cap;
    }
}

