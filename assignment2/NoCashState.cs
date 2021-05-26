using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class NoCashState : IATMState
    {
        private ATMMachine machine;

        public NoCashState(ATMMachine machine)
        {

        }

        public void EnterPincode()
        {
            //
        }

        public void InsertCard()
        {
            throw new NotImplementedException();
        }

        public void RejectCard()
        {
            throw new NotImplementedException();
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Not enough cash available in machine");
        }
    }
}
