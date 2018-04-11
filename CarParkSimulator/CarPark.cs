using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        private int currentSpaces = 5;
        private int maxSpaces = 5;
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
            ticketMachine.CarArrived();
        }

        public void TicketDispensed()
        {
            entryBarrier.Raise();
        }

        public void CarEnteredCarPark()
        {
            entryBarrier.Lower();
            ticketMachine.ClearMessage();
            currentSpaces = currentSpaces - 1;
            if (this.IsFull()) fullSign.SetLit(true);
        }
        public void CarArrivedAtExit()
        {
            ticketValidator.CarArrived();
        }
        public void TicketValidated()
        {
            exitBarrier.Raise();
        }

        public void CarExitedCarPark()
        {
            exitBarrier.Lower();
            ticketValidator.ClearMessage();
            currentSpaces = currentSpaces + 1;
            fullSign.SetLit(false);
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
