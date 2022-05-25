namespace _4сем_c_sharp_3
{
    partial class adding_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.length_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colour_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sin_textbox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(131, 16);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(12, 19);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(113, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Введите имя ромба: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите длину стороны ромба: ";
            // 
            // length_textbox
            // 
            this.length_textbox.Location = new System.Drawing.Point(186, 70);
            this.length_textbox.Name = "length_textbox";
            this.length_textbox.Size = new System.Drawing.Size(100, 20);
            this.length_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите цвет ромба: ";
            // 
            // colour_textbox
            // 
            this.colour_textbox.Location = new System.Drawing.Point(134, 116);
            this.colour_textbox.Name = "colour_textbox";
            this.colour_textbox.Size = new System.Drawing.Size(100, 20);
            this.colour_textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите cинус угла ромба: ";
            // 
            // sin_textbox
            // 
            this.sin_textbox.Location = new System.Drawing.Point(165, 161);
            this.sin_textbox.Name = "sin_textbox";
            this.sin_textbox.Size = new System.Drawing.Size(100, 20);
            this.sin_textbox.TabIndex = 7;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(28, 201);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(258, 50);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // adding_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 263);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.sin_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colour_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.length_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_textbox);
            this.Name = "adding_form";
            this.Text = "adding_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox length_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colour_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sin_textbox;
        private System.Windows.Forms.Button save_button;
    }
}