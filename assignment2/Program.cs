using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        public void Start()
        {
            ATMMachine machine = new ATMMachine(2000);

            string command = "";
            do
            {
                Console.WriteLine("Please enter your command");
                command = Console.ReadLine();

                if (command == "insert card")
                {
                    //
                }

                else if (command == "reject card")
                {
                    //
                }

                else if (command == "enter pincode")
                {
                    //
                }
                else if (command == "withdraw cash")
                {
                    //
                }
                else
                {
                    Console.WriteLine("entered unknown command");
                }
            }
            while (command != "stop");

        }
    }
}
