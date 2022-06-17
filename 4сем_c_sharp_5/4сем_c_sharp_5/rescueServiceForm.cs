using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5.Objects;

namespace _4сем_c_sharp_5
{
    public partial class rescueServiceForm : Form
    {
        private readonly IEnumerable<Type> rescueServiceTypes;
        public Type SelectedType { get; private set; }


        public rescueServiceForm(IEnumerable<Type> rescueServiceTypes)
        {
            InitializeComponent();

            this.rescueServiceTypes = rescueServiceTypes;

            SelectedType = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedType = rescueServiceTypes.First(type => type.Name == comboBox1.SelectedItem.ToString());
            button1.Enabled = true;
        }

        private void rescueServiceForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(rescueServiceTypes.Select(type => type.Name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedType == null)
            {
                MessageBox.Show("Вы не выбрали тип службы спасения");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
