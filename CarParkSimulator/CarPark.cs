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

        public bool isFull()
        {
            if (currentSpaces == 0)
                return true;
            else
                return false;
        }
    }
}
