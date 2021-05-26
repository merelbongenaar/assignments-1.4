using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class SubSystem
    {
        private SubSystem subSystem;
        private Logger logger;

        public SubSystem()
        {
            logger = Logger.GetInstance();
        }

        public void DoSomeWork()
        {
            logger.Log("SubSystem", "doing some work");
        }
        public void DoSomeMoreWork()
        {
            logger.Log("SubSystem", "doing some more work");
        }


    }
}
