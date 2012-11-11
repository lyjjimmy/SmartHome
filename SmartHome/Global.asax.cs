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
            List<Carer> carersList = new List<Carer>();
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
            //carers
            Carer carer1 = new Carer("Oreo Lingard", "02-11223344");
            carer1.UserPassword = "carer1";
            Carer carer2 = new Carer("Lily", "02-99887766");
            carer2.UserPassword = "carer2";
            Carer carer3 = new Carer("Omo", "03-74620139");
            carer3.UserPassword = "carer3";

            //patient relationships
            patient1.addDoctor(doctor1);
            patient1.addDoctor(doctor2);
            patient1.addCarer(carer1);
            patient1.addCarer(carer2);
            patient2.addDoctor(doctor2);
            patient2.addCarer(carer2);
            patient2.addCarer(carer3);
            patient3.addDoctor(doctor1);
            patient3.addDoctor(doctor3);
            patient3.addCarer(carer3);
            patient4.addDoctor(doctor2);
            patient4.addCarer(carer2);
            patient5.addDoctor(doctor3);
            patient5.addCarer(carer1);

            //doctor's patient list
            doctor1.LinkPatient(patient1);
            doctor1.LinkPatient(patient3);
            doctor2.LinkPatient(patient1);
            doctor2.LinkPatient(patient2);
            doctor2.LinkPatient(patient4);
            doctor3.LinkPatient(patient3);
            doctor3.LinkPatient(patient5);

            //carer's patient list
            carer1.LinkPatient(patient1);
            carer1.LinkPatient(patient5);
            carer2.LinkPatient(patient1);
            carer2.LinkPatient(patient2);
            carer2.LinkPatient(patient4);
            carer3.LinkPatient(patient2);
            carer3.LinkPatient(patient3);

            //add all peopel to the list
            patientsList.Add(patient1);
            patientsList.Add(patient2);
            patientsList.Add(patient3);
            patientsList.Add(patient4);
            patientsList.Add(patient5);
            doctorsList.Add(doctor1);
            doctorsList.Add(doctor2);
            doctorsList.Add(doctor3);
            carersList.Add(carer1);
            carersList.Add(carer2);
            carersList.Add(carer3);
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
