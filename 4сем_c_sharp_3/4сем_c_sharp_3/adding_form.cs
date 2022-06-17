using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Objects;

namespace _4сем_c_sharp_3
{
    public partial class adding_form : Form
    {
        IFigure figure;

        public adding_form()
        {
            InitializeComponent();
        }

        public void saving()
        {
            string name = name_textbox.Text;
            double len = Double.Parse(length_textbox.Text);
            string colour = colour_textbox.Text;
            double sin = Double.Parse(sin_textbox.Text);
            figure = new Rhombus(name, true, 4, colour, sin, len);

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            saving();
            Form1 form = this.Owner as Form1;
            form.add(figure);
            this.Close();
        }
    }
}
