using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SmartHome.Classes;

namespace SmartHome
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Patient patient;

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
            patient = new Patient("David Mayor", "02-12345678");
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
            doctorsBulletedList.Items.Clear();
            foreach (Doctor d in patient.associatedDoctors)
            {
                doctorsBulletedList.Items.Add(d.ToString());
            }
            carrersBulletedList.Items.Clear();
            foreach (Carrer c in patient.associatedCarrers)
            {
                
                carrersBulletedList.Items.Add(c.ToString());
            }
            
            //for demo purpose only
            //sensor generator setup
            heartRateSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.HEART_RATE, "HR-1", "-1"));
            bloodPressureSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.BLOOD_PRESSURE, "BP-1", "-1"));
            temperatureSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.TEMPERATURE, "BT-1", "-1"));
            bodyStatusSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.FAIL_STATUS, "MM-1", "False"));
            locationSimulator = new RandomSensorGenerator(new Sensor((int)Sensor.SensorTypes.GPS, "LS-1", "0,0"));
            //end sensor generator setup
            //end demo only stuff

        }

        protected void startRecordButton_Click(object sender, EventArgs e)
        {
            monitorTimer.Enabled = true;
            //TODO more works to bring this things refersh every 30 seconds with live data
            //TODO using a Timer to bring this thing live
            //TODO brings medical alarm here
        }

        private void GenerateDataOnce()
        {
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
        }

        private void MedicalStatusMonitoring()
        {
            //These criteria is described in SmartHome.Classes.RandomSensorGenerator class initially
            //heart rate warning zone <30, >120
            //blood pressure warning zone <80, >150
            //body temperature warning zone <36.0 >38.0
            //body status waring status: fall
            int outint;
            double outdouble;
            //test whether all numberic text in some field is parsable
            if (int.TryParse(liveHeartRateLabel.Text, out outint)
                && int.TryParse(liveBloodPressureLabel.Text, out outint)
                && double.TryParse(liveTemperatureLabel.Text, out outdouble))
            {
                //heart rate warning
                int heartRate = int.Parse(liveHeartRateLabel.Text);
                int bloodPressure = int.Parse(liveBloodPressureLabel.Text);
                double temperature = double.Parse(liveTemperatureLabel.Text);
                string fallStatus = liveFallStatusLabel.Text;

                if ((heartRate < 40 || heartRate > 110)
                    || (bloodPressure < 90 || bloodPressure > 140)
                    || (temperature < 36.5 || temperature > 38.5)
                    || fallStatus.Equals("True"))   // any of the medical data in warning zone
                {
                    alarmStatusLabel.Text = "In Danger, contact medical service!!";
                    alarmStatusLabel.ForeColor = System.Drawing.Color.Red;
                    alarmStatusLabel.Font.Bold = true;
                }
                else
                {
                    alarmStatusLabel.Text = "Normal";
                    alarmStatusLabel.ForeColor = System.Drawing.Color.Green;
                    alarmStatusLabel.Font.Bold = false;
                }
            }
        }

        protected void endRecordButton_Click(object sender, EventArgs e)
        {
            monitorTimer.Enabled = false;
        }

        protected void monitorTimer_Tick(object sender, EventArgs e)
        {
            GenerateDataOnce();
            MedicalStatusMonitoring();
        }

    }
}