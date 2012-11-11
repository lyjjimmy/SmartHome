using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Carer : User
    {
        public List<Patient> carerPatient;

        public Carer(string name, string contact)
        {
            UserName = name;
            UserContact = contact;
            UserType = (int)User.UserTypes.CARRER;
            carerPatient = new List<Patient>();
        }

        public void LinkPatient(Patient patient)
        {
            carerPatient.Add(patient);
        }
    }
}