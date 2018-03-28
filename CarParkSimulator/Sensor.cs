using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Sensor
    {
        protected bool carOnSensor;

        public void CarDetected()
        {
            this.carOnSensor = true;
        }
        public void CarLeftSensor()
        {
            this.carOnSensor = false;
        }
        public bool IsCarOnSensor()
        {
            if (carOnSensor == true)
                return true;
            else
                return false;
        }
    }
}
