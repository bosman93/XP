using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Menu
    {
        private int currentState=-1;
        public void choice(int x)
        { 
            if(x==0 || x==1 || x==2)
            {
                currentState = x;
            }
            
        }
        public int getCurrentState()
        {
            return currentState;
        }

        public void readChoice()
        {
            int x=Console.Read();
            choice(x);
        }

        public void printMenu()
        {
            Console.WriteLine("Konwerter");
            Console.WriteLine("Wybierz kierunek konwersji:");
            Console.WriteLine("1. Z podanej kwoty");
            Console.WriteLine("2. Na podana kwote");
            Console.WriteLine("0. Zakoncz");
        }



     }
}
