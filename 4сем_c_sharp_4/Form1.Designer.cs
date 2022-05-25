namespace _4сем_c_sharp_4
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
            this.classes_names_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.methods_button = new System.Windows.Forms.Button();
            this.do_method_button = new System.Windows.Forms.Button();
            this.parameter_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // classes_names_button
            // 
            this.classes_names_button.Location = new System.Drawing.Point(440, 22);
            this.classes_names_button.Name = "classes_names_button";
            this.classes_names_button.Size = new System.Drawing.Size(257, 23);
            this.classes_names_button.TabIndex = 0;
            this.classes_names_button.Text = "Получить список названий классов";
            this.classes_names_button.UseVisualStyleBackColor = true;
            this.classes_names_button.Click += new System.EventHandler(this.classes_names_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название класса";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(440, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(518, 180);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название метода";
            // 
            // methods_button
            // 
            this.methods_button.Location = new System.Drawing.Point(440, 118);
            this.methods_button.Name = "methods_button";
            this.methods_button.Size = new System.Drawing.Size(257, 23);
            this.methods_button.TabIndex = 6;
            this.methods_button.Text = "Получить список методов классов";
            this.methods_button.UseVisualStyleBackColor = true;
            this.methods_button.Click += new System.EventHandler(this.methods_button_Click);
            // 
            // do_method_button
            // 
            this.do_method_button.Location = new System.Drawing.Point(38, 144);
            this.do_method_button.Name = "do_method_button";
            this.do_method_button.Size = new System.Drawing.Size(257, 23);
            this.do_method_button.TabIndex = 7;
            this.do_method_button.Text = "Выполнить выбранный метод";
            this.do_method_button.UseVisualStyleBackColor = true;
            this.do_method_button.Click += new System.EventHandler(this.do_method_button_Click);
            // 
            // parameter_button
            // 
            this.parameter_button.Location = new System.Drawing.Point(54, 250);
            this.parameter_button.Name = "parameter_button";
            this.parameter_button.Size = new System.Drawing.Size(257, 23);
            this.parameter_button.TabIndex = 8;
            this.parameter_button.Text = "Ввести параметр";
            this.parameter_button.UseVisualStyleBackColor = true;
            this.parameter_button.Click += new System.EventHandler(this.parameter_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.parameter_button);
            this.Controls.Add(this.do_method_button);
            this.Controls.Add(this.methods_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classes_names_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button classes_names_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button methods_button;
        private System.Windows.Forms.Button do_method_button;
        private System.Windows.Forms.Button parameter_button;
        private System.Windows.Forms.TextBox textBox1;
    }
}

