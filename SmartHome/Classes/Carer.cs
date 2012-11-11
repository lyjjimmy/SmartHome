using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Carer : User
    {
        public List<Resident> carerResident;

        public Carer(string name, string contact)
        {
            UserName = name;
            UserContact = contact;
            UserType = (int)User.UserTypes.CARER;
            carerResident = new List<Resident>();
        }

        public void LinkResident(Resident resident)
        {
            carerResident.Add(resident);
        }
    }
}