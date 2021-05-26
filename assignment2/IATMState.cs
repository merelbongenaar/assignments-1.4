using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    interface IATMState
    {
        void EnterPincode();
        void InsertCard();
        void RejectCard();
        void WithdrawCash();
    }
}
