﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Duck
    {
        public double Weight;
        public string Name;
        public double Tonus;
        public int Age;
        public double Sleeping;

        public void Eat()
        {
            Weight += 0.2;
            Tonus += 1;
            ChekSleeping();
        }
        public void Sleep()
        {
            Tonus += 1;
            ChekSleeping();
        }
        public void Trening()
        {
            Sleeping -= 1;
            Tonus += 1;
            Weight -= 0.1;
            ChekSleeping();
        }
        public void Swimming()
        {
            Tonus += 1;
            Sleeping += 1;
            ChekSleeping();
        }
        public void Competition()
        {
            Tonus -= 2;
            Sleeping -= 2;
            Weight -= 0.2;
            ChekSleeping();
        }
        private void ChekSleeping()
        {
            if (Sleeping < 0)
            {
                Tonus -= 0.5;
            }
        }
        private bool ChekALive()
        {
            if (Age >= 10)
            {
                return false;

            }
             return true;  
                   
        }
        
        }

    }


}

