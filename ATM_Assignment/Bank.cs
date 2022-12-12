using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ATM_Assignment
{
    public class Bank
    {
        int bankCapacity;
        public int NumberOfCustomers=0 ;

        public Bank(int bankCapacity) { this.bankCapacity = bankCapacity; }
        public Bank() { }
        public void AddNewAccount(BankAccount Acc) {
            string x = Acc.getcardNumber.ToString();
            string y = Acc.getpinCode.ToString();
           
            if (x.Length == 9 && y.Length == 4)
            {


                if (bankCapacity >= NumberOfCustomers)
                {
                    NumberOfCustomers++;

                    StreamWriter Info2 = new StreamWriter("CustomersInfo.txt");
                    Info2.WriteLine(Acc.getfirstname + " " + Acc.getlastname + " " + Acc.getemail + " " + Acc.getcardNumber + " " + Acc.getpinCode + " " + Acc.getaccountBalance);

                    Info2.Close();

                }
            }
            else
                Console.WriteLine("CardNumber or PinCode is Not Valid!");

        }

        public bool IsBankUser(string cardnumber,string pincode) {
            string line;
            StreamReader Info = new StreamReader("CustomersInfo.txt");
            line = Info.ReadLine();
            while (line != null)
            {
              
                string[] words =line.Split(" ");
               
                if (cardnumber == words[3] && pincode == words[4]) {
                    Info.Close();
                    return true;
                }
                    
                line = Info.ReadLine();

            }
            Info.Close();
            return false;
        }
        public int CheckBalance(string CardNumber, string PinCode) {
            string line;
            StreamReader Info = new StreamReader("CustomersInfo.txt");
            line = Info.ReadLine();
            while (line != null)
            {
                string[] words = line.Split(" ");
                if (CardNumber == words[3] && PinCode == words[4]) {
                    int x = Int32.Parse(words[5]);
                    Info.Close();
                    return x;
                }
                    
                line = Info.ReadLine();
            }
            Info.Close();
            return 0;
        }

        public void Withdraw(BankAccount Account,int withdrawAmount) {


            Account.setbalance(Account.getaccountBalance - withdrawAmount);
            string line;
            StreamReader Info = new StreamReader("CustomersInfo.txt");
            line = Info.ReadLine();
            StreamWriter Info2 = new StreamWriter("CustomerInfoEdit.txt");
            while (line != null)
            {
                string[] words = line.Split(" ");
                if (Account.getcardNumber == words[3] && Account.getpinCode == words[4])
                {

                    words[5] = Account.getaccountBalance.ToString();
                    string linex = "";
                    for (int i = 0; i < 6; i++)
                    {
                        linex = linex + words[i] + " ";
                    }
                    Info2.WriteLine(linex);
                }
                else Info2.WriteLine(line);

                line = Info.ReadLine();
            }

            Info.Close();
            Info2.Close();
            StreamWriter Info3 = new StreamWriter("CustomersInfo.txt");
            Info3.Flush();
            StreamReader Info4 = new StreamReader("CustomerInfoEdit.txt");
            string line2;
            line2 = Info4.ReadLine();
            while (line2 != null)
            {
                Info3.WriteLine(line2);
                line2 = Info4.ReadLine();
            }
            Info3.Close();
            Info4.Close();
        }

        public void Deposit(BankAccount Account, int withdrawAmount)
        {
           
            Account.setbalance(Account.getaccountBalance+withdrawAmount);
            string line;
            StreamReader Info = new StreamReader("CustomersInfo.txt");
            line = Info.ReadLine();
            StreamWriter Info2 = new StreamWriter("CustomerInfoEdit.txt");
            while (line != null)
            {
                string[] words = line.Split(" ");
                if (Account.getcardNumber == words[3] && Account.getpinCode == words[4])
                {
                   
                    words[5] = Account.getaccountBalance.ToString();
                    string linex="";
                    for (int i=0;i<6;i++) {
                        linex = linex  + words[i] + " ";
                    }
                    Info2.WriteLine(linex);
                }
                else Info2.WriteLine(line);

                line = Info.ReadLine();
            }
            
            Info.Close();
            Info2.Close();
            StreamWriter Info3 = new StreamWriter("CustomersInfo.txt");
            Info3.Flush();
            StreamReader Info4 = new StreamReader("CustomerInfoEdit.txt");
            string line2;
            line2 = Info4.ReadLine();
            while (line2 != null) {
                Info3.WriteLine(line2);
                line2 = Info4.ReadLine();
            }
            Info3.Close();
            Info4.Close();

        }
        public void Save()
        {
            StreamReader Info0 = new StreamReader("CustomersInfo.txt");
            StreamWriter Info1 = new StreamWriter("final.txt");
            Info1.Flush();
        
            string line2;
            line2 = Info0.ReadLine();
            while (line2 != null)
            {
                Info1.WriteLine(line2);
                line2 = Info0.ReadLine();
            }
            Info0.Close();
            Info1.Close();
        }
        public void Load()
        {
            StreamReader Info0 = new StreamReader("CustomersInfo.txt");
            string line2;
            line2 = Info0.ReadLine();
            while (line2 != null)
            {
                Console.WriteLine(line2);
                line2 = Info0.ReadLine();
            }
            Info0.Close();
            
        }
    }
}
