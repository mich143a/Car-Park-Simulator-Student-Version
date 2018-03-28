using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Ticket
    {
        private bool paid;

        public bool IsPaid()
        {
            if (paid == true)
                return true;
            else
                return false;
        }

        public void SetPaid(bool paid)
        {
            this.paid = paid;
        }
    }
}
