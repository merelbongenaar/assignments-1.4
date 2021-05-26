using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class NoCardState : IATMState
    {
        private ATMMachine machine;

        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
