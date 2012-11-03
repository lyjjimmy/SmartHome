using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Carrer : User
    {
        public List<Patient> carrerPatient;

        public Carrer(string name, string contact)
        {
            UserName = name;
            UserContact = contact;
            UserType = (int)User.UserTypes.CARRER;
            carrerPatient = new List<Patient>();
        }

<<<<<<< HEAD
        public void linkPatient(Patient patient)
=======
        public void LinkPatient(Patient patient)
>>>>>>> User Classes
        {
            carrerPatient.Add(patient);
        }
    }
}