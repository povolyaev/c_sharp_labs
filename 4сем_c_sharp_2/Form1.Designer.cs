namespace _4сем_c_sharp_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.party_name_button = new System.Windows.Forms.Button();
            this.party_ly_name_button = new System.Windows.Forms.Button();
            this.party_name_textbox = new System.Windows.Forms.TextBox();
            this.party_ly_name_textbox = new System.Windows.Forms.TextBox();
            this.party_name_output_button = new System.Windows.Forms.Button();
            this.party_name_output = new System.Windows.Forms.TextBox();
            this.amount_button = new System.Windows.Forms.Button();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.percentage_button = new System.Windows.Forms.Button();
            this.percentage_textbox = new System.Windows.Forms.TextBox();
            this.amount_output_button = new System.Windows.Forms.Button();
            this.party_amount_output_textbox = new System.Windows.Forms.TextBox();
            this.percentage_output_button = new System.Windows.Forms.Button();
            this.party_percentage_output_textbox = new System.Windows.Forms.TextBox();
            this.party_info_button = new System.Windows.Forms.Button();
            this.party_info_textbox = new System.Windows.Forms.TextBox();
            this.party_ly_info_textbox = new System.Windows.Forms.TextBox();
            this.party_ly_info_button = new System.Windows.Forms.Button();
            this.percentage_ly_output_button = new System.Windows.Forms.Button();
            this.party_ly_percentage_output_textbox = new System.Windows.Forms.TextBox();
            this.amount_ly_output_button = new System.Windows.Forms.Button();
            this.party_ly_amount_output_textbox = new System.Windows.Forms.TextBox();
            this.people_ly_button = new System.Windows.Forms.Button();
            this.ly_amount_textbox = new System.Windows.Forms.TextBox();
            this.party_ly_name_output_button = new System.Windows.Forms.Button();
            this.party_ly_name_output = new System.Windows.Forms.TextBox();
            this.ly_amount_button = new System.Windows.Forms.Button();
            this.people_ly_textbox = new System.Windows.Forms.TextBox();
            this.ly_percentage_button = new System.Windows.Forms.Button();
            this.ly_percentage_text = new System.Windows.Forms.TextBox();
            this.party_ly_amount_button = new System.Windows.Forms.Button();
            this.ly_amount_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работа с партией (родителем)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(570, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Работа с партией (потомком)";
            // 
            // party_name_button
            // 
            this.party_name_button.Location = new System.Drawing.Point(17, 36);
            this.party_name_button.Name = "party_name_button";
            this.party_name_button.Size = new System.Drawing.Size(103, 33);
            this.party_name_button.TabIndex = 2;
            this.party_name_button.Text = "Ввести название";
            this.party_name_button.UseVisualStyleBackColor = true;
            this.party_name_button.Click += new System.EventHandler(this.party_name_button_Click);
            // 
            // party_ly_name_button
            // 
            this.party_ly_name_button.Location = new System.Drawing.Point(721, 30);
            this.party_ly_name_button.Name = "party_ly_name_button";
            this.party_ly_name_button.Size = new System.Drawing.Size(103, 33);
            this.party_ly_name_button.TabIndex = 3;
            this.party_ly_name_button.Text = "Ввести название";
            this.party_ly_name_button.UseVisualStyleBackColor = true;
            this.party_ly_name_button.Click += new System.EventHandler(this.party_ly_name_button_Click);
            // 
            // party_name_textbox
            // 
            this.party_name_textbox.Location = new System.Drawing.Point(127, 43);
            this.party_name_textbox.Name = "party_name_textbox";
            this.party_name_textbox.Size = new System.Drawing.Size(152, 20);
            this.party_name_textbox.TabIndex = 4;
            // 
            // party_ly_name_textbox
            // 
            this.party_ly_name_textbox.Location = new System.Drawing.Point(574, 37);
            this.party_ly_name_textbox.Name = "party_ly_name_textbox";
            this.party_ly_name_textbox.Size = new System.Drawing.Size(141, 20);
            this.party_ly_name_textbox.TabIndex = 5;
            // 
            // party_name_output_button
            // 
            this.party_name_output_button.Location = new System.Drawing.Point(17, 220);
            this.party_name_output_button.Name = "party_name_output_button";
            this.party_name_output_button.Size = new System.Drawing.Size(113, 33);
            this.party_name_output_button.TabIndex = 6;
            this.party_name_output_button.Text = "Вывести название";
            this.party_name_output_button.UseVisualStyleBackColor = true;
            this.party_name_output_button.Click += new System.EventHandler(this.party_name_output_button_Click);
            // 
            // party_name_output
            // 
            this.party_name_output.Location = new System.Drawing.Point(136, 227);
            this.party_name_output.Name = "party_name_output";
            this.party_name_output.ReadOnly = true;
            this.party_name_output.Size = new System.Drawing.Size(143, 20);
            this.party_name_output.TabIndex = 7;
            // 
            // amount_button
            // 
            this.amount_button.Location = new System.Drawing.Point(17, 86);
            this.amount_button.Name = "amount_button";
            this.amount_button.Size = new System.Drawing.Size(103, 45);
            this.amount_button.TabIndex = 8;
            this.amount_button.Text = "Ввести кол-во участников";
            this.amount_button.UseVisualStyleBackColor = true;
            this.amount_button.Click += new System.EventHandler(this.amount_button_Click);
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(126, 99);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(153, 20);
            this.amount_textbox.TabIndex = 9;
            // 
            // percentage_button
            // 
            this.percentage_button.Location = new System.Drawing.Point(17, 137);
            this.percentage_button.Name = "percentage_button";
            this.percentage_button.Size = new System.Drawing.Size(103, 45);
            this.percentage_button.TabIndex = 10;
            this.percentage_button.Text = "Ввести процент голосов";
            this.percentage_button.UseVisualStyleBackColor = true;
            this.percentage_button.Click += new System.EventHandler(this.percentage_button_Click);
            // 
            // percentage_textbox
            // 
            this.percentage_textbox.Location = new System.Drawing.Point(126, 150);
            this.percentage_textbox.Name = "percentage_textbox";
            this.percentage_textbox.Size = new System.Drawing.Size(153, 20);
            this.percentage_textbox.TabIndex = 11;
            // 
            // amount_output_button
            // 
            this.amount_output_button.Location = new System.Drawing.Point(17, 275);
            this.amount_output_button.Name = "amount_output_button";
            this.amount_output_button.Size = new System.Drawing.Size(103, 45);
            this.amount_output_button.TabIndex = 12;
            this.amount_output_button.Text = "Вывести кол-во участников";
            this.amount_output_button.UseVisualStyleBackColor = true;
            this.amount_output_button.Click += new System.EventHandler(this.amount_output_button_Click);
            // 
            // party_amount_output_textbox
            // 
            this.party_amount_output_textbox.Location = new System.Drawing.Point(136, 288);
            this.party_amount_output_textbox.Name = "party_amount_output_textbox";
            this.party_amount_output_textbox.ReadOnly = true;
            this.party_amount_output_textbox.Size = new System.Drawing.Size(143, 20);
            this.party_amount_output_textbox.TabIndex = 13;
            // 
            // percentage_output_button
            // 
            this.percentage_output_button.Location = new System.Drawing.Point(17, 338);
            this.percentage_output_button.Name = "percentage_output_button";
            this.percentage_output_button.Size = new System.Drawing.Size(103, 45);
            this.percentage_output_button.TabIndex = 14;
            this.percentage_output_button.Text = "Вывести процент голосов";
            this.percentage_output_button.UseVisualStyleBackColor = true;
            this.percentage_output_button.Click += new System.EventHandler(this.percentage_output_button_Click);
            // 
            // party_percentage_output_textbox
            // 
            this.party_percentage_output_textbox.Location = new System.Drawing.Point(136, 351);
            this.party_percentage_output_textbox.Name = "party_percentage_output_textbox";
            this.party_percentage_output_textbox.ReadOnly = true;
            this.party_percentage_output_textbox.Size = new System.Drawing.Size(143, 20);
            this.party_percentage_output_textbox.TabIndex = 15;
            // 
            // party_info_button
            // 
            this.party_info_button.Location = new System.Drawing.Point(17, 402);
            this.party_info_button.Name = "party_info_button";
            this.party_info_button.Size = new System.Drawing.Size(103, 69);
            this.party_info_button.TabIndex = 16;
            this.party_info_button.Text = "Вывести всю информацию о партии";
            this.party_info_button.UseVisualStyleBackColor = true;
            this.party_info_button.Click += new System.EventHandler(this.party_info_button_Click);
            // 
            // party_info_textbox
            // 
            this.party_info_textbox.Location = new System.Drawing.Point(136, 402);
            this.party_info_textbox.Multiline = true;
            this.party_info_textbox.Name = "party_info_textbox";
            this.party_info_textbox.ReadOnly = true;
            this.party_info_textbox.Size = new System.Drawing.Size(246, 71);
            this.party_info_textbox.TabIndex = 17;
            // 
            // party_ly_info_textbox
            // 
            this.party_ly_info_textbox.Location = new System.Drawing.Point(469, 570);
            this.party_ly_info_textbox.Multiline = true;
            this.party_ly_info_textbox.Name = "party_ly_info_textbox";
            this.party_ly_info_textbox.ReadOnly = true;
            this.party_ly_info_textbox.Size = new System.Drawing.Size(246, 69);
            this.party_ly_info_textbox.TabIndex = 18;
            // 
            // party_ly_info_button
            // 
            this.party_ly_info_button.Location = new System.Drawing.Point(721, 570);
            this.party_ly_info_button.Name = "party_ly_info_button";
            this.party_ly_info_button.Size = new System.Drawing.Size(103, 69);
            this.party_ly_info_button.TabIndex = 19;
            this.party_ly_info_button.Text = "Вывести всю информацию о партии";
            this.party_ly_info_button.UseVisualStyleBackColor = true;
            this.party_ly_info_button.Click += new System.EventHandler(this.party_ly_info_button_Click);
            // 
            // percentage_ly_output_button
            // 
            this.percentage_ly_output_button.Location = new System.Drawing.Point(721, 449);
            this.percentage_ly_output_button.Name = "percentage_ly_output_button";
            this.percentage_ly_output_button.Size = new System.Drawing.Size(103, 45);
            this.percentage_ly_output_button.TabIndex = 20;
            this.percentage_ly_output_button.Text = "Вывести процент голосов";
            this.percentage_ly_output_button.UseVisualStyleBackColor = true;
            this.percentage_ly_output_button.Click += new System.EventHandler(this.percentage_ly_output_button_Click);
            // 
            // party_ly_percentage_output_textbox
            // 
            this.party_ly_percentage_output_textbox.Location = new System.Drawing.Point(572, 462);
            this.party_ly_percentage_output_textbox.Name = "party_ly_percentage_output_textbox";
            this.party_ly_percentage_output_textbox.ReadOnly = true;
            this.party_ly_percentage_output_textbox.Size = new System.Drawing.Size(143, 20);
            this.party_ly_percentage_output_textbox.TabIndex = 21;
            // 
            // amount_ly_output_button
            // 
            this.amount_ly_output_button.Location = new System.Drawing.Point(721, 383);
            this.amount_ly_output_button.Name = "amount_ly_output_button";
            this.amount_ly_output_button.Size = new System.Drawing.Size(103, 45);
            this.amount_ly_output_button.TabIndex = 22;
            this.amount_ly_output_button.Text = "Вывести кол-во участников";
            this.amount_ly_output_button.UseVisualStyleBackColor = true;
            this.amount_ly_output_button.Click += new System.EventHandler(this.amount_ly_output_button_Click);
            // 
            // party_ly_amount_output_textbox
            // 
            this.party_ly_amount_output_textbox.Location = new System.Drawing.Point(562, 396);
            this.party_ly_amount_output_textbox.Name = "party_ly_amount_output_textbox";
            this.party_ly_amount_output_textbox.ReadOnly = true;
            this.party_ly_amount_output_textbox.Size = new System.Drawing.Size(143, 20);
            this.party_ly_amount_output_textbox.TabIndex = 23;
            // 
            // people_ly_button
            // 
            this.people_ly_button.Location = new System.Drawing.Point(721, 500);
            this.people_ly_button.Name = "people_ly_button";
            this.people_ly_button.Size = new System.Drawing.Size(103, 61);
            this.people_ly_button.TabIndex = 24;
            this.people_ly_button.Text = "Вывести кол-во прошлогодних участников";
            this.people_ly_button.UseVisualStyleBackColor = true;
            this.people_ly_button.Click += new System.EventHandler(this.people_ly_button_Click_1);
            // 
            // ly_amount_textbox
            // 
            this.ly_amount_textbox.Location = new System.Drawing.Point(572, 521);
            this.ly_amount_textbox.Name = "ly_amount_textbox";
            this.ly_amount_textbox.ReadOnly = true;
            this.ly_amount_textbox.Size = new System.Drawing.Size(143, 20);
            this.ly_amount_textbox.TabIndex = 25;
            // 
            // party_ly_name_output_button
            // 
            this.party_ly_name_output_button.Location = new System.Drawing.Point(711, 338);
            this.party_ly_name_output_button.Name = "party_ly_name_output_button";
            this.party_ly_name_output_button.Size = new System.Drawing.Size(113, 33);
            this.party_ly_name_output_button.TabIndex = 26;
            this.party_ly_name_output_button.Text = "Вывести название";
            this.party_ly_name_output_button.UseVisualStyleBackColor = true;
            this.party_ly_name_output_button.Click += new System.EventHandler(this.party_ly_name_output_button_Click);
            // 
            // party_ly_name_output
            // 
            this.party_ly_name_output.Location = new System.Drawing.Point(562, 338);
            this.party_ly_name_output.Name = "party_ly_name_output";
            this.party_ly_name_output.ReadOnly = true;
            this.party_ly_name_output.Size = new System.Drawing.Size(143, 20);
            this.party_ly_name_output.TabIndex = 27;
            // 
            // ly_amount_button
            // 
            this.ly_amount_button.Location = new System.Drawing.Point(721, 227);
            this.ly_amount_button.Name = "ly_amount_button";
            this.ly_amount_button.Size = new System.Drawing.Size(103, 53);
            this.ly_amount_button.TabIndex = 28;
            this.ly_amount_button.Text = "Ввести кол-во прошлогодних участников";
            this.ly_amount_button.UseVisualStyleBackColor = true;
            this.ly_amount_button.Click += new System.EventHandler(this.ly_amount_button_Click);
            // 
            // people_ly_textbox
            // 
            this.people_ly_textbox.Location = new System.Drawing.Point(562, 244);
            this.people_ly_textbox.Name = "people_ly_textbox";
            this.people_ly_textbox.Size = new System.Drawing.Size(153, 20);
            this.people_ly_textbox.TabIndex = 29;
            // 
            // ly_percentage_button
            // 
            this.ly_percentage_button.Location = new System.Drawing.Point(721, 150);
            this.ly_percentage_button.Name = "ly_percentage_button";
            this.ly_percentage_button.Size = new System.Drawing.Size(103, 45);
            this.ly_percentage_button.TabIndex = 30;
            this.ly_percentage_button.Text = "Ввести процент голосов";
            this.ly_percentage_button.UseVisualStyleBackColor = true;
            this.ly_percentage_button.Click += new System.EventHandler(this.ly_percentage_button_Click);
            // 
            // ly_percentage_text
            // 
            this.ly_percentage_text.Location = new System.Drawing.Point(562, 163);
            this.ly_percentage_text.Name = "ly_percentage_text";
            this.ly_percentage_text.Size = new System.Drawing.Size(153, 20);
            this.ly_percentage_text.TabIndex = 31;
            // 
            // party_ly_amount_button
            // 
            this.party_ly_amount_button.Location = new System.Drawing.Point(721, 86);
            this.party_ly_amount_button.Name = "party_ly_amount_button";
            this.party_ly_amount_button.Size = new System.Drawing.Size(103, 45);
            this.party_ly_amount_button.TabIndex = 32;
            this.party_ly_amount_button.Text = "Ввести кол-во участников";
            this.party_ly_amount_button.UseVisualStyleBackColor = true;
            this.party_ly_amount_button.Click += new System.EventHandler(this.party_ly_amount_button_Click);
            // 
            // ly_amount_text
            // 
            this.ly_amount_text.Location = new System.Drawing.Point(562, 99);
            this.ly_amount_text.Name = "ly_amount_text";
            this.ly_amount_text.Size = new System.Drawing.Size(153, 20);
            this.ly_amount_text.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 651);
            this.Controls.Add(this.ly_amount_text);
            this.Controls.Add(this.party_ly_amount_button);
            this.Controls.Add(this.ly_percentage_text);
            this.Controls.Add(this.ly_percentage_button);
            this.Controls.Add(this.people_ly_textbox);
            this.Controls.Add(this.ly_amount_button);
            this.Controls.Add(this.party_ly_name_output);
            this.Controls.Add(this.party_ly_name_output_button);
            this.Controls.Add(this.ly_amount_textbox);
            this.Controls.Add(this.people_ly_button);
            this.Controls.Add(this.party_ly_amount_output_textbox);
            this.Controls.Add(this.amount_ly_output_button);
            this.Controls.Add(this.party_ly_percentage_output_textbox);
            this.Controls.Add(this.percentage_ly_output_button);
            this.Controls.Add(this.party_ly_info_button);
            this.Controls.Add(this.party_ly_info_textbox);
            this.Controls.Add(this.party_info_textbox);
            this.Controls.Add(this.party_info_button);
            this.Controls.Add(this.party_percentage_output_textbox);
            this.Controls.Add(this.percentage_output_button);
            this.Controls.Add(this.party_amount_output_textbox);
            this.Controls.Add(this.amount_output_button);
            this.Controls.Add(this.percentage_textbox);
            this.Controls.Add(this.percentage_button);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.amount_button);
            this.Controls.Add(this.party_name_output);
            this.Controls.Add(this.party_name_output_button);
            this.Controls.Add(this.party_ly_name_textbox);
            this.Controls.Add(this.party_name_textbox);
            this.Controls.Add(this.party_ly_name_button);
            this.Controls.Add(this.party_name_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button party_name_button;
        private System.Windows.Forms.Button party_ly_name_button;
        private System.Windows.Forms.TextBox party_name_textbox;
        private System.Windows.Forms.TextBox party_ly_name_textbox;
        private System.Windows.Forms.Button party_name_output_button;
        private System.Windows.Forms.TextBox party_name_output;
        private System.Windows.Forms.Button amount_button;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.Button percentage_button;
        private System.Windows.Forms.TextBox percentage_textbox;
        private System.Windows.Forms.Button amount_output_button;
        private System.Windows.Forms.TextBox party_amount_output_textbox;
        private System.Windows.Forms.Button percentage_output_button;
        private System.Windows.Forms.TextBox party_percentage_output_textbox;
        private System.Windows.Forms.Button party_info_button;
        private System.Windows.Forms.TextBox party_info_textbox;
        private System.Windows.Forms.TextBox party_ly_info_textbox;
        private System.Windows.Forms.Button party_ly_info_button;
        private System.Windows.Forms.Button percentage_ly_output_button;
        private System.Windows.Forms.TextBox party_ly_percentage_output_textbox;
        private System.Windows.Forms.Button amount_ly_output_button;
        private System.Windows.Forms.TextBox party_ly_amount_output_textbox;
        private System.Windows.Forms.Button people_ly_button;
        private System.Windows.Forms.TextBox ly_amount_textbox;
        private System.Windows.Forms.Button party_ly_name_output_button;
        private System.Windows.Forms.TextBox party_ly_name_output;
        private System.Windows.Forms.Button ly_amount_button;
        private System.Windows.Forms.TextBox people_ly_textbox;
        private System.Windows.Forms.Button ly_percentage_button;
        private System.Windows.Forms.TextBox ly_percentage_text;
        private System.Windows.Forms.Button party_ly_amount_button;
        private System.Windows.Forms.TextBox ly_amount_text;
    }
}

