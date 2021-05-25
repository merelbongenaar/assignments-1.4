using System;

namespace assignment1
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
            Logger logger = Logger.GetInstance();

            logger.Log("main", "starting");

        }
    }
}
