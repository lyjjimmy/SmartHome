using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SmartHome.Classes;
using System.Threading;

namespace SmartHome
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Patient patient;
        bool liveMonitorStatus = false;

        //for demo purpose only 
        RandomSensorGenerator heartRateSimulator;
        RandomSensorGenerator bloodPressureSimulator;
        RandomSensorGenerator temperatureSimulator;
        RandomSensorGenerator bodyStatusSimulator;
        RandomSensorGenerator locationSimulator;
        // end demo only stuff

        
        protected void Page_Load(object sender, EventArgs e)
        {
            //for demo purpose only
            //dump data for testing only
            patient = new Patient("David Daves", "02-12345678");
            Doctor doctor1 = new Doctor("Yanni", "02-98765432");
            Doctor doctor2 = new Doctor("Cominal", "02-55667788");
            Carrer carrer1 = new Carrer("Oreo Lingard", "02-11223344");
            Carrer carrer2 = new Carrer("Lily", "02-99887766");
            patient.addDoctor(doctor1);
            patient.addDoctor(doctor2);
            patient.addCarrer(carrer1);
            patient.addCarrer(carrer2);
            //end dump testing data
            //end demo only stuff

            patientNameLabel.Text = patient.UserName;
            patientContactLabel.Text = patient.UserContact;
            string doctorString = "";
            foreach (Doctor d in patient.associatedDoctors)
            {
                doctorString += d.ToString() + "\n";
            }
            patientDoctorLabel.Text = doctorString;
            string carrerString = "";
            foreach (Carrer c in patient.associatedCarrers)
            {
                carrerString += c.ToString() + "\n";
            }
            patientCarrerLabel.Text = carrerString;
            
            //for demo purpose only
            //sensor generator stuff
            heartRateSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.HEART_RATE, "HR-1", "-1"));
            bloodPressureSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.BLOOD_PRESSURE, "BP-1", "-1"));
            temperatureSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.TEMPERATURE, "BT-1", "-1"));
            bodyStatusSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.FAIL_STATUS, "MM-1", "False"));
            locationSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.GPS, "LS-1", "0,0"));
            //end demo only stuff
        }

        protected void startRecordButton_Click(object sender, EventArgs e)
        {
            //liveMonitorStatus = true;

            //while (liveMonitorStatus != false)
            //{
                liveHeartRateLabel.Text = heartRateSimulator.returnData();
                heartRateSimulator.Sensor.SensorData = liveHeartRateLabel.Text;

                liveBloodPressureLabel.Text = bloodPressureSimulator.returnData();
                bloodPressureSimulator.Sensor.SensorData = liveBloodPressureLabel.Text;

                liveTemperatureLabel.Text = temperatureSimulator.returnData();
                temperatureSimulator.Sensor.SensorData = liveTemperatureLabel.Text;

                liveFallStatusLabel.Text = bodyStatusSimulator.returnData();
                bodyStatusSimulator.Sensor.SensorData = liveFallStatusLabel.Text;

                liveLocationLabel.Text = locationSimulator.returnData();
                locationSimulator.Sensor.SensorData = liveLocationLabel.Text;
                //Thread.Sleep(5000);
            //}
            //TODO more works to bring this things refersh every 30 seconds with live data
            //TODO using a Timer to bring this thing live
            //TODO brings medical alarm here
        }

        protected void endRecordButton_Click(object sender, EventArgs e)
        {
            //liveMonitorStatus = false;l
        }
    }
}