using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Patient : User
    {
        public Patient(string name, string contact)
        {
            userName = name;
            userContact = contact;
            userType = (int)UserTypes.PATIENT;
        }
    }
}