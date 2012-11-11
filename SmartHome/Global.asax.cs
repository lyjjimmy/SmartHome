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
            List<Resident> residentsList = new List<Resident>();
            List<Doctor> doctorsList = new List<Doctor>();
            List<Carer> carersList = new List<Carer>();
            List<Reminder> reminders = new List<Reminder>();

            //dummy testing data only
            //for demo purpose only
            //residents
            Resident resident1 = new Resident("David Mayor", "02-12345678");
            resident1.UserPassword = "resident1";
            Resident resident2 = new Resident("Norman", "02-98765432");
            resident2.UserPassword = "resident2";
            Resident resident3 = new Resident("Patrick", "03-75419862");
            resident3.UserPassword = "resident3";
            Resident resident4 = new Resident("Elizebath", "03-41569852");
            resident4.UserPassword = "resident4";
            Resident resident5 = new Resident("Parramata", "02-12578462");
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

            //resident relationships
            resident1.addDoctor(doctor1);
            resident1.addDoctor(doctor2);
            resident1.addCarer(carer1);
            resident1.addCarer(carer2);
            resident2.addDoctor(doctor2);
            resident2.addCarer(carer2);
            resident2.addCarer(carer3);
            resident3.addDoctor(doctor1);
            resident3.addDoctor(doctor3);
            resident3.addCarer(carer3);
            resident4.addDoctor(doctor2);
            resident4.addCarer(carer2);
            resident5.addDoctor(doctor3);
            resident5.addCarer(carer1);

            //doctor's resident list
            doctor1.LinkResident(resident1);
            doctor1.LinkResident(resident3);
            doctor2.LinkResident(resident1);
            doctor2.LinkResident(resident2);
            doctor2.LinkResident(resident4);
            doctor3.LinkResident(resident3);
            doctor3.LinkResident(resident5);

            //carer's resident list
            carer1.LinkResident(resident1);
            carer1.LinkResident(resident5);
            carer2.LinkResident(resident1);
            carer2.LinkResident(resident2);
            carer2.LinkResident(resident4);
            carer3.LinkResident(resident2);
            carer3.LinkResident(resident3);

            //add all peopel to the list
            residentsList.Add(resident1);
            residentsList.Add(resident2);
            residentsList.Add(resident3);
            residentsList.Add(resident4);
            residentsList.Add(resident5);
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
