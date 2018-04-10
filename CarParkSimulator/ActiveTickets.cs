using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        //variables
        private List<Ticket> Tickets;


        //constructor
        public ActiveTickets()
        {
            Tickets = new List<Ticket>();
        }



        //functions
        public List<Ticket> GetTickets()
        {
            return Tickets;
        }

        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }

        public void RemoveTicket()
        {
            int index = Tickets.Count() - 1;
            Tickets.RemoveAt(index);
        }

    }
}
