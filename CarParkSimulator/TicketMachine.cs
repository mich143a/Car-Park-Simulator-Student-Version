using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
    {
        private string message;
        ActiveTickets activeTickets;

        public TicketMachine(ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }

        public void AssignCarPark(CarPark carPark)
        {

        }
        public void CarArrived()
        {

        }
        public void PrintTicket()
        {

        }
        public void ClearMessage()
        {
            message = "";
        }
        public void GetMessage(string message)
        {
            return message;
        }
    }
}
