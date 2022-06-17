using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.Objects;

namespace _4сем_c_sharp_1
{
    public partial class Form1 : Form
    {

        private Lab1.Objects.Day day;

        public Form1()
        {
            InitializeComponent();
            day = new Lab1.Objects.Day();
        }

        private void change_hour_button_Click(object sender, EventArgs e)
        {
            int res = -1;
            try
            {
                res = Convert.ToInt32(hour_textbox.Text);
            }
            catch (FormatException)
            { }
            
            if (res == -1 || res > 23 || res < 0)
            {
                MessageBox.Show("В строке было что-то плохое");
            }
            else
            {
                day.h.set_hour(res);
                MessageBox.Show("Данные изменены");
                hour_textbox.Clear();
            }
        }

        private void change_minutes_button_Click(object sender, EventArgs e)
        {
            int res = -1;
            try
            {
                res = Convert.ToInt32(minutes_textbox.Text);
            }
            catch (FormatException)
            { }

            if (res == -1 || res > 59 || res < 0)
            {
                MessageBox.Show("В строке было что-то плохое");
            }
            else
            {
                day.m.set_min(res);
                MessageBox.Show("Данные изменены");
                minutes_textbox.Clear();
            }
        }

        private void time_check_button_Click(object sender, EventArgs e)
        {
            time_textbox.Clear();
            time_textbox.Text += day.time();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func_textbox.Clear();
            func_textbox.Text += day.func();
        }
    }
}
