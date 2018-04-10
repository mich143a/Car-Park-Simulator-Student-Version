using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        private int currentSpaces;
        private int maxSpaces;
        TicketMachine ticketMachine;
        TicketValidator ticketValidator;
        FullSign fullSign;
        Barrier entryBarrier;
        Barrier exitBarrier;


        public CarPark(TicketMachine ticketMachine, TicketValidator ticketValidator, FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier)
        {
            this.ticketMachine = ticketMachine;
            this.ticketValidator = ticketValidator;
            this.fullSign = fullSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
        }

        public void CarArrivedAtEntrance()
        {
            
        }

        public void TicketDispensed()
        {

        }

        public void CarEnteredCarPark()
        {

        }
        public void TicketValidated()
        {

        }

        public void CarExitedCarPark()
        {

        }

        public bool IsFull()
        {
            if (currentSpaces == 0)
                return true;
            else
                return false;
        }
        public bool IsEmpty()
        {
            if (currentSpaces == maxSpaces)
                return true;
            else
                return false;
        }
        public bool HasSpaces()
        {
            if (currentSpaces > 0)
                return true;
            else
                return false;
        }
        public int GetCurrentSpaces()
        {
            return currentSpaces;
        }
    }
}
