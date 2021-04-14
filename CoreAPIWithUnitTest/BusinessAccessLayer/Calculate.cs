using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccessLayer
{
    public class Calculate
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Substarction (int num1, int num2)
        {
            if (num2 > num1)
                return -1;
            return num1 - num2;
        }

        public int Mulitplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividion(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
