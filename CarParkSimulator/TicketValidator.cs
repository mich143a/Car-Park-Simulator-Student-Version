using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
    {
        private string message;
        ActiveTickets activeTickets;
        CarPark carPark;
        public TicketValidator(ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }

        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }
        public void CarArrived()
        {
            message = "Please insert your ticket.";
        }

        public void TicketEntered(Ticket ticket) {
            activeTickets.RemoveTicket(ticket);
            message = "Thank you, drive safely.";
            carPark.TicketValidated();
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
