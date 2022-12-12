using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Assignment
{
    public class BankAccount
    {
        string firstname;
        string lastname;
        string email;
        public string PinCode;
        public string CardNumber;
        int accountBalance;
        public BankAccount(Person p1,string email,string cardNumber,string pinCode,int accountBalance) {
            this.email = email;
            this.CardNumber = cardNumber;
            this.PinCode = pinCode;
            this.accountBalance = accountBalance;
            firstname=(p1.getfirstname());
            lastname=(p1.getlastname);
        }
        public string getfirstname =>firstname;
        public string getlastname =>lastname;
        public string getemail => email;
        public string getcardNumber => CardNumber;
        public string getpinCode => PinCode;
        public int getaccountBalance => accountBalance;
        public void setbalance(int accountBalance) { this.accountBalance = accountBalance;   }

    }
}
