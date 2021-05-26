using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class MainSystem
    {
        private SubSystem subSystem;
       
        public MainSystem()
        {
            subSystem = new SubSystem();
        }

        public void DoSomeMainWork()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("MainSystem", "doing some main work");
            
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }
    }
}
