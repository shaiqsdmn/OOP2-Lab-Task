﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Lab2
{
    class Calculator : BasicCalculatorInterface, ScientificCalculatorInterface
    {
        int result;
        public int division(int x, int y)
        {
            return x/y;
        }

        public int factorial(int x)
        {
            int i = 1;
            for (int s = 1; s <= x; s++)
            {
                i = i * s;
            }
            return i;
        }

        public int multiplication(int x, int y)
        {
            return x*y;
        }

        public int sub(int x , int y)
        {
            return x - y;
        }

        public int sum(int x,int y)
        {
            return x + y;
        }

        public int XtoY(int x, int y)
        {
            while(y != 0)
            {
                result *= x;
                --y;
            }
            return result;
        }
    }
}
