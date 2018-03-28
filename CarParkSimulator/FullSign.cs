using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class FullSign
    {
        private bool lit;

        public bool isLit(bool lit)
        {
            if (currentSpaces == 0)
            {
                lit = true;
            }
            else
                lit = false;
        }
        public void SetLit(bool lit)
        {
            this.lit = lit;
        }
    }
}
