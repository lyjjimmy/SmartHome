using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using SmartHome;
using SmartHome.Classes;

namespace SmartHome
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();

            //
            List<Patient> patientsList = new List<Patient>();
            List<Doctor> doctorsList = new List<Doctor>();
            List<Carrer> carrersList = new List<Carrer>();
            List<Reminder> reminders = new List<Reminder>();

            //dummy testing data only
            //for demo purpose only
            //patients
            Patient patient1 = new Patient("David Mayor", "02-12345678");
            patient1.UserPassword = "patient1";
            Patient patient2 = new Patient("Norman", "02-98765432");
            patient2.UserPassword = "patient2";
            Patient patient3 = new Patient("Patrick", "03-75419862");
            patient3.UserPassword = "patient3";
            Patient patient4 = new Patient("Elizebath", "03-41569852");
            patient4.UserPassword = "patient4";
            Patient patient5 = new Patient("Parramata", "02-12578462");
            //doctors
            Doctor doctor1 = new Doctor("Yanni", "02-98765432");
            doctor1.UserPassword = "doctor1";
            Doctor doctor2 = new Doctor("Cominal", "02-55667788");
            doctor2.UserPassword = "doctor2";
            Doctor doctor3 = new Doctor("Weather Man", "03-48512697");
            doctor3.UserPassword = "doctor3";
            //carrers
            Carrer carrer1 = new Carrer("Oreo Lingard", "02-11223344");
            carrer1.UserPassword = "carrer1";
            Carrer carrer2 = new Carrer("Lily", "02-99887766");
            carrer2.UserPassword = "carrer2";
            Carrer carrer3 = new Carrer("Omo", "03-74620139");
            carrer3.UserPassword = "carrer3";

            //patient relationships
            patient1.addDoctor(doctor1);
            patient1.addDoctor(doctor2);
            patient1.addCarrer(carrer1);
            patient1.addCarrer(carrer2);
            patient2.addDoctor(doctor2);
            patient2.addCarrer(carrer2);
            patient2.addCarrer(carrer3);
            patient3.addDoctor(doctor1);
            patient3.addDoctor(doctor3);
            patient3.addCarrer(carrer3);
            patient4.addDoctor(doctor2);
            patient4.addCarrer(carrer2);
            patient5.addDoctor(doctor3);
            patient5.addCarrer(carrer1);

            //doctor's patient list
            doctor1.LinkPatient(patient1);
            doctor1.LinkPatient(patient3);
            doctor2.LinkPatient(patient1);
            doctor2.LinkPatient(patient2);
            doctor2.LinkPatient(patient4);
            doctor3.LinkPatient(patient3);
            doctor3.LinkPatient(patient5);

            //carrer's patient list
            carrer1.LinkPatient(patient1);
            carrer1.LinkPatient(patient5);
            carrer2.LinkPatient(patient1);
            carrer2.LinkPatient(patient2);
            carrer2.LinkPatient(patient4);
            carrer3.LinkPatient(patient2);
            carrer3.LinkPatient(patient3);

            //add all peopel to the list
            patientsList.Add(patient1);
            patientsList.Add(patient2);
            patientsList.Add(patient3);
            patientsList.Add(patient4);
            patientsList.Add(patient5);
            doctorsList.Add(doctor1);
            doctorsList.Add(doctor2);
            doctorsList.Add(doctor3);
            carrersList.Add(carrer1);
            carrersList.Add(carrer2);
            carrersList.Add(carrer3);
            //end demo only stuff
            //end dummy testing data
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
