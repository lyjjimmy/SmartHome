using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Patient:User
    {
        public List<Doctor> associatedDoctors;
        public List<Carer> associatedCarers;

        public Patient(string name, string contact)
        {
            UserName = name;
            UserContact = contact;
            UserType = (int)User.UserTypes.PATIENT;
            associatedDoctors = new List<Doctor>();
            associatedCarers = new List<Carer>();
        }

        public void addDoctor(Doctor doctor)
        {
            associatedDoctors.Add(doctor);
        }

        public void addCarer(Carer carer)
        {
            associatedCarers.Add(carer);
        }
    }
}