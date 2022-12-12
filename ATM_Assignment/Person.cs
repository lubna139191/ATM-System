using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Assignment
{
    public class Person
    {
        string firstname="test";
        string lastname="test";
        public void setfirstname(string firstname)=>this.firstname = firstname;
        public void setlastname(string lastname)=>this.lastname = lastname;

        public string getfirstname() { return firstname; }
        public string getlastname => lastname;
    }
}
