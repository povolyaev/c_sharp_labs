using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Objects
{
    public class Party
    {
        public string name;
        public int amount_of_people;
        public double percentage_of_votes;

        public Party()
        {
            name = "";
            amount_of_people = 0;
            percentage_of_votes = 0;
        }

        public void set_name(string n)
        {
            name = n;
        }

        public void set_amount(int amount)
        {
            if (amount > 0)
                amount_of_people = amount;
            else
                amount_of_people = 0;
        }

        public void set_percentage(double percent)
        {
            if (percent > 0)
                percentage_of_votes = percent;
            else
                percentage_of_votes = 0;
        }

        public string get_name()
        { return name; }

        public int get_amount()
        { return amount_of_people; }

        public double get_percentage()
        { return percentage_of_votes; }

        public double q;
        public void count_q()
        {
            q = 0.3 * amount_of_people + 0.7 * percentage_of_votes;
        }

        public string print()
        {
            count_q();
            return "Партия " + name + "  численностью " + amount_of_people + " человек и процентом голосов " + percentage_of_votes + "%.\nПараметр Q = " + q;
        }
    }
}
