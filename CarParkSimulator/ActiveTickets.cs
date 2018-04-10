using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        private List<Ticket> tickets;

        public ActiveTickets() {
            tickets = new List<Ticket>();
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }
        public void RemoveTicket()
        {
            tickets.Remove(ticket);
        }
    }
}
