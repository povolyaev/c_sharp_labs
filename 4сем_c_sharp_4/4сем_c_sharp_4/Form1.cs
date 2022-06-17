using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Lab4.Objects;

namespace _4сем_c_sharp_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classes_names_button_Click(object sender, EventArgs e)
        {
            Type baseType = typeof(Figure);

            var allTypes = baseType.Assembly.ExportedTypes.Where(t => baseType.IsAssignableFrom(t));
            foreach (var m in allTypes)
            {
                if (m.Name != "Figure")
                {
                    comboBox1.Items.Add(m);
                }
            }

        }

        private void methods_button_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Type type = (Type)comboBox1.SelectedItem;

            Figure figure = (Figure)Activator.CreateInstance(type);
            var methods = Reflect.GetMethod<Figure>(figure);

            foreach (MethodInfo m in methods)
            {
                comboBox2.Items.Add(m);
            }
        }

        private void do_method_button_Click(object sender, EventArgs e)
        {
            Type type = (Type)comboBox1.SelectedItem;
            Figure figure = (Figure)Activator.CreateInstance(type);
            MethodInfo methodInfo = (MethodInfo)comboBox2.SelectedItem;
            ParameterInfo[] parameters = methodInfo.GetParameters();
            string s = "";
            object[] arr = new object[parameters.Length];
            int i = 0;
            foreach (ParameterInfo info in parameters)
            {
                s += Convert.ToString(info.ParameterType);
                Type new_type = info.ParameterType;
                arr[i] = Convert.ChangeType(textBox1.Text, new_type);
                i++;
                s += "  ";
            }

            var k = methodInfo.Invoke(figure, arr);
            label1.Text = Convert.ToString(k);
            label3.Text = s;
        }

        private void parameter_button_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }
    }
}
