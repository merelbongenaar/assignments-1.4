using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class ATMMachine
    {
        private int amountInMachine;
        private IATMState cardPresent;
        private IATMState correctPinCode;
        private IATMState noCard;
        private IATMState noCash;

        private IATMState machineState;

        public int AmountInMachine { get; set; }

        public ATMMachine(int nr)
        {
            amountInMachine = nr;
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);

            //machine gets an initial current state
        }

        public void EnterPincode()
        {

        }

        public void GetCardPresentState()
        {

        }

        public void GetCorrectPinState()
        {

        }

        public void GetNoCardState()
        {

        }

        public void GetNoCashState()
        {

        }

        public void InsertCard()
        {
            //machineState.CardPresentState();
        }

        public void RejectCard()
        {

        }

        public void SetAmountInMachine()
        {

        }

        public void SetMachineState()
        {

        }

        public void WithdrawCash()
        {

        }


    }
}
