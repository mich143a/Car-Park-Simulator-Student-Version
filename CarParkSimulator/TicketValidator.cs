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

        public TicketValidator(ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }

        public void AssignCarPark(CarPark carPark)
        {

        }
        public void CarArrived()
        {

        }
        public void TicketEntered()
        {

        }
        public void ClearMessage()
        {
            message = " ";
        }
        public void GetMessage(string message)
        {
            this.message = message;
        }
    }
}
