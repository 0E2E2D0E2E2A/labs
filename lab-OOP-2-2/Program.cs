using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_OOP_2_2
{
    [Serializable]
    class TailsException : Exception
    {
        protected Exception exception;
        private string message;

        public TailsException() { } 

        public TailsException(string message) : base(message)
        {

        }

        
        public TailsException(string message, Exception inner) : base(message, inner) 
        {
            this.message = message;
            inner = exception;
        }
    }

    class Tails : TailsException
    {
        Random rnd = new Random();

        public Tails(string[] array, string[] choise) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = choise[rnd.Next(0, choise.Length)];
            }

            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "Решка")
                {
                    k++;

                    if (k == array.Length)
                    {
                        throw new TailsException($"При подкидывании монеты {array.Length} раз подряд выпала решка", exception);
                    }
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[2];
            string[] choise = new string[] { "Решка", "Орёл" };

            try
            {
                Tails tails = new Tails(array, choise);

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            catch (TailsException ex)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}