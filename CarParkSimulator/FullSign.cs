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
            if (lit == true)
            {
                return true;
            }
            else
                return false;
        }
        public void SetLit(bool lit)
        {
            this.lit = lit;
        }
    }
}
