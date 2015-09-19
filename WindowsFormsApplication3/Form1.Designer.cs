namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.T_box = new System.Windows.Forms.TextBox();
            this.N_box = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.S_box = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Enter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Терминалы";
            this.textBox1.Visible = false;
            // 
            // T_box
            // 
            this.T_box.Location = new System.Drawing.Point(118, 12);
            this.T_box.Name = "T_box";
            this.T_box.ReadOnly = true;
            this.T_box.Size = new System.Drawing.Size(100, 20);
            this.T_box.TabIndex = 1;
            this.T_box.Visible = false;
            this.T_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // N_box
            // 
            this.N_box.Location = new System.Drawing.Point(118, 38);
            this.N_box.Name = "N_box";
            this.N_box.ReadOnly = true;
            this.N_box.Size = new System.Drawing.Size(100, 20);
            this.N_box.TabIndex = 2;
            this.N_box.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Нетерминалы";
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 64);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Аксиома";
            this.textBox5.Visible = false;
            // 
            // S_box
            // 
            this.S_box.Location = new System.Drawing.Point(118, 64);
            this.S_box.Name = "S_box";
            this.S_box.ReadOnly = true;
            this.S_box.Size = new System.Drawing.Size(100, 20);
            this.S_box.TabIndex = 5;
            this.S_box.Visible = false;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(12, 204);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(793, 20);
            this.status.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(489, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(271, 121);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(383, 12);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(100, 20);
            this.Enter.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 59);
            this.button2.TabIndex = 10;
            this.button2.Text = "Определить тип";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 236);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.S_box);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.N_box);
            this.Controls.Add(this.T_box);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox T_box;
        private System.Windows.Forms.TextBox N_box;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox S_box;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox Enter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

