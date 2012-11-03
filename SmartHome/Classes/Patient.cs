using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Patient:User
    {
        public List<Doctor> associatedDoctors;
        public List<Carrer> associatedCarrers;

        public Patient(string name, string contact)
        {
            UserName = name;
            UserContact = contact;
            UserType = (int)User.UserTypes.PATIENT;
            associatedDoctors = new List<Doctor>();
            associatedCarrers = new List<Carrer>();
        }

        public void addDoctor(Doctor doctor)
        {
            associatedDoctors.Add(doctor);
        }

        public void addCarrer(Carrer carrer)
        {
            associatedCarrers.Add(carrer);
        }
    }
}