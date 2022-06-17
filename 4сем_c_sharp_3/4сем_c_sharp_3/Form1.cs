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
    public partial class Form1 : Form
    {

        List<IFigure> figures = new List<IFigure>();

        public Form1()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            adding_form add = new adding_form();
            add.Owner = this;
            add.ShowDialog();
            write();
            add.Dispose();
        }

        public void write()
        {
            listBox1.Items.Clear();
            foreach (Rhombus rhombus in figures)
            {
                double perimeter = rhombus.count_perimeter();
                double area = rhombus.count_area();
                listBox1.Items.Add(rhombus.name + " " + rhombus.colour + " " + "Длина стороны = " + rhombus.length_of_side + " Периметр = " + perimeter.ToString() + " Площадь = " + area.ToString());
            }
        }

        public void add(IFigure figure)
        {
            figures.Add(figure);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (figures.Count() > 0)
            {
                figures.RemoveAt(listBox1.SelectedIndex);
                write();
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы 1 элемент");
            }
        }
    }
}
