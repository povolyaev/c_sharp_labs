namespace _4сем_c_sharp_1
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
            this.change_hour_button = new System.Windows.Forms.Button();
            this.hour_textbox = new System.Windows.Forms.TextBox();
            this.minutes_textbox = new System.Windows.Forms.TextBox();
            this.change_minutes_button = new System.Windows.Forms.Button();
            this.time_check_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.time_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.func_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // change_hour_button
            // 
            this.change_hour_button.Location = new System.Drawing.Point(12, 12);
            this.change_hour_button.Name = "change_hour_button";
            this.change_hour_button.Size = new System.Drawing.Size(175, 54);
            this.change_hour_button.TabIndex = 0;
            this.change_hour_button.Text = "Ввести новое значение часа\r\n";
            this.change_hour_button.UseVisualStyleBackColor = true;
            this.change_hour_button.Click += new System.EventHandler(this.change_hour_button_Click);
            // 
            // hour_textbox
            // 
            this.hour_textbox.Location = new System.Drawing.Point(13, 73);
            this.hour_textbox.Name = "hour_textbox";
            this.hour_textbox.Size = new System.Drawing.Size(174, 20);
            this.hour_textbox.TabIndex = 1;
            // 
            // minutes_textbox
            // 
            this.minutes_textbox.Location = new System.Drawing.Point(261, 72);
            this.minutes_textbox.Name = "minutes_textbox";
            this.minutes_textbox.Size = new System.Drawing.Size(172, 20);
            this.minutes_textbox.TabIndex = 2;
            // 
            // change_minutes_button
            // 
            this.change_minutes_button.Location = new System.Drawing.Point(261, 12);
            this.change_minutes_button.Name = "change_minutes_button";
            this.change_minutes_button.Size = new System.Drawing.Size(172, 54);
            this.change_minutes_button.TabIndex = 3;
            this.change_minutes_button.Text = "Ввести новое значение минут";
            this.change_minutes_button.UseVisualStyleBackColor = true;
            this.change_minutes_button.Click += new System.EventHandler(this.change_minutes_button_Click);
            // 
            // time_check_button
            // 
            this.time_check_button.Location = new System.Drawing.Point(13, 216);
            this.time_check_button.Name = "time_check_button";
            this.time_check_button.Size = new System.Drawing.Size(174, 51);
            this.time_check_button.TabIndex = 4;
            this.time_check_button.Text = "Узнать время";
            this.time_check_button.UseVisualStyleBackColor = true;
            this.time_check_button.Click += new System.EventHandler(this.time_check_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "На часах сейчас";
            // 
            // time_textbox
            // 
            this.time_textbox.Location = new System.Drawing.Point(58, 302);
            this.time_textbox.Name = "time_textbox";
            this.time_textbox.ReadOnly = true;
            this.time_textbox.Size = new System.Drawing.Size(81, 20);
            this.time_textbox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Узнать время суток";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(303, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "А за окном";
            // 
            // func_textbox
            // 
            this.func_textbox.Location = new System.Drawing.Point(307, 302);
            this.func_textbox.Name = "func_textbox";
            this.func_textbox.ReadOnly = true;
            this.func_textbox.Size = new System.Drawing.Size(81, 20);
            this.func_textbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.func_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_check_button);
            this.Controls.Add(this.change_minutes_button);
            this.Controls.Add(this.minutes_textbox);
            this.Controls.Add(this.hour_textbox);
            this.Controls.Add(this.change_hour_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_hour_button;
        private System.Windows.Forms.TextBox hour_textbox;
        private System.Windows.Forms.TextBox minutes_textbox;
        private System.Windows.Forms.Button change_minutes_button;
        private System.Windows.Forms.Button time_check_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox time_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox func_textbox;
    }
}

