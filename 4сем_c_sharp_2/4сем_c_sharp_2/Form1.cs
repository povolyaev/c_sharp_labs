using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Objects;

namespace _4сем_c_sharp_2
{
    public partial class Form1 : Form
    {
        private Party party;
        private Party_last_year party_ly;

        public Form1()
        {
            InitializeComponent();
            party = new Party();
            party_ly = new Party_last_year();
        }

        private void party_name_button_Click(object sender, EventArgs e)
        {
            party.set_name(party_name_textbox.Text);
        }

        private void amount_button_Click(object sender, EventArgs e)
        {
            int res = -1;
            try
            {
                res = Convert.ToInt32(amount_textbox.Text);
            }
            catch (FormatException)
            { }

            if (res == -1)
            {
                MessageBox.Show("В строке было что-то плохое");
            }
            else
            {
                party.set_amount(res);
                MessageBox.Show("Данные изменены");
                amount_textbox.Clear();
            }
        }

        private void percentage_button_Click(object sender, EventArgs e)
        {
            int res = -1;
            try
            {
                res = Convert.ToInt32(percentage_textbox.Text);
            }
            catch (FormatException)
            { }

            if (res == -1)
            {
                MessageBox.Show("В строке было что-то плохое");
            }
            else
            {
                party.set_percentage(res);
                MessageBox.Show("Данные изменены");
                percentage_textbox.Clear();
            }
        }

        private void party_name_output_button_Click(object sender, EventArgs e)
        {
            party_name_output.Clear();
            party_name_output.Text += party.get_name();
        }

        private void amount_output_button_Click(object sender, EventArgs e)
        {
            party_amount_output_textbox.Clear();
            party_amount_output_textbox.Text += party.get_amount().ToString();
        }

        private void percentage_output_button_Click(object sender, EventArgs e)
        {
            party_percentage_output_textbox.Clear();
            party_percentage_output_textbox.Text += party.get_percentage().ToString() + "%";
        }

        private void party_info_button_Click(object sender, EventArgs e)
        {
            party_info_textbox.Clear();
            party_info_textbox.Text += party.print();
        }

        private void party_ly_name_button_Click(object sender, EventArgs e)
        {
            party_ly.set_name(party_ly_name_textbox.Text);
        }

        private void party_ly_amount_button_Click(object sender, EventArgs e)
        {
            int res = -1;
            try
            {
                res = Convert.ToInt32(ly_amount_text.Text);
            }
            catch (FormatException)
            { }

            if (res == -1)
            {
                MessageBox.Show("В строке было что-то плохое");
            }
            else
            {
                party_ly.set_amount(res);
                MessageBox.Show("Данные изменены");
                ly_amount_text.Clear();
            }
        }

        private void ly_percentage_button_Click(object sender, EventArgs e)
        {
            int res = -1;
            try
            {
                res = Convert.ToInt32(ly_percentage_text.Text);
            }
            catch (FormatException)
            { }

            if (res == -1)
            {
                MessageBox.Show("В строке было что-то плохое");
            }
            else
            {
                party_ly.set_percentage(res);
                MessageBox.Show("Данные изменены");
                ly_percentage_text.Clear();
            }
        }

        private void ly_amount_button_Click(object sender, EventArgs e)
        {
            int res = -1;
            try
            {
                res = Convert.ToInt32(people_ly_textbox.Text);
            }
            catch (FormatException)
            { }

            if (res == -1)
            {
                MessageBox.Show("В строке было что-то плохое");
            }
            else
            {
                party_ly.set_last_year_amount(res);
                MessageBox.Show("Данные изменены");
                people_ly_textbox.Clear();
            }
        }

        private void party_ly_name_output_button_Click(object sender, EventArgs e)
        {
            party_ly_name_output.Clear();
            party_ly_name_output.Text += party_ly.get_name();
        }

        private void amount_ly_output_button_Click(object sender, EventArgs e)
        {
            party_ly_amount_output_textbox.Clear();
            party_ly_amount_output_textbox.Text += party_ly.get_amount().ToString();
        }

        private void percentage_ly_output_button_Click(object sender, EventArgs e)
        {
            party_ly_percentage_output_textbox.Clear();
            party_ly_percentage_output_textbox.Text += party_ly.get_percentage().ToString() + "%";
        }

        private void party_ly_info_button_Click(object sender, EventArgs e)
        {
            party_ly_info_textbox.Clear();
            party_ly_info_textbox.Text += party_ly.print();
        }

        private void people_ly_button_Click_1(object sender, EventArgs e)
        {
            ly_amount_textbox.Clear();
            ly_amount_textbox.Text += party_ly.get_last_year_amount().ToString();
        }
    }
}
