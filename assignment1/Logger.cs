using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Logger
    {
        private int numberOfLines;
        private static Logger uniqueInstance;

        private Logger()
        {
            numberOfLines = 0;
        }

        public void Log(string system, string log)
        {
            numberOfLines++;
            Console.WriteLine($"{numberOfLines} - [{system}] {log}");
        }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }

            return uniqueInstance;
        }


        //hsghs
    }
}
