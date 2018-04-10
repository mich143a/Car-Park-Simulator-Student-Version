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
        CarPark carPark;
        public TicketMachine(ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }

        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }
        public void CarArrived()
        {
            message = "Pless press to get a ticket.";
        }
        public void PrintTicket()
        {
            activeTickets.AddTicket();
            message = "Thankyou, enjoy your stay.";
            carPark.TicketDispensed();
        }
        public void ClearMessage()
        {
            message = "";
        }
        public string GetMessage(string message)
        {
            return message;
        }
    }
}
