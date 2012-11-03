using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Doctor : User
    {
        public List<Patient> doctorPatient;

        public Doctor(string name, string contact)
        {
            UserName = name;
            UserContact = contact;
            UserType = (int)User.UserTypes.DOCTOR;
            doctorPatient = new List<Patient>();
        }

        public void linkPatient(Patient patient)
        {
            doctorPatient.Add(patient);
        }
    }
}