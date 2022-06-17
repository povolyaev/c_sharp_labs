using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Objects
{
    public class Party_last_year : Party
    {
        public int last_year_amount;

        public void set_last_year_amount(int amount)
        {
            if (amount > 0)
                last_year_amount = amount;
            else
                last_year_amount = 0;
        }

        public int get_last_year_amount()
        { return last_year_amount; }

        public double qp;
        void count_qp()
        {
            count_q();
            if (amount_of_people > last_year_amount)
                qp = 1.2 * q;
            else
                qp = 0.8 * q;
        }

        new public string print()
        {
            count_q();
            count_qp();
            return "Партия " + name + "  численностью " + amount_of_people + " человек и процентом голосов " + percentage_of_votes + "%.\nПараметр Q = " + q + " Параметр p = " + last_year_amount + " Параметр qp = " + qp;
        }
    }
}
