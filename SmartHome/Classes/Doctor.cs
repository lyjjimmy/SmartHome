using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Doctor : User
    {
        public List<Resident> doctorResident;

        public Doctor(string name, string contact)
        {
            UserName = name;
            UserContact = contact;
            UserType = (int)User.UserTypes.DOCTOR;
            doctorResident = new List<Resident>();
        }

        public void LinkResident(Resident resident)
        {
            doctorResident.Add(resident);
        }
    }
}