using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

    class ArithProgression : ISeries
    {
        int d = 2;
        int x = 0;

        public void SetStart(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
        }

        public int GetNext()
        {
            int secondNumber = x + d;
            return secondNumber;
        }

        public void Reset() 
        {
            int firstNumber = x - d;
        }
    }

    class GeomProgression : ISeries
    {
        int q = 3;
        int x = 0;

        public void SetStart(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
        }

        public int GetNext()
        {
            int secondNumber = x * q;
            return secondNumber;
        }

        public void Reset()
        {
            int firstNumber = x / q;
        }
    }
}
