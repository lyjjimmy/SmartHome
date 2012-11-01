using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Sensor
    {
        private enum SensorTypes { HEART_RATE, BLOOD_PRESSURE, TEMPERATURE, FAIL_STATUS, GPS };

        private int sensorType;
        public int SensorType
        {
            get { return SensorType; }
            set { SensorType = value; }
        }

        private string sensorName;
        public string SensorName
        {
            get { return SensorName; }
            set { SensorName = value; }
        }

        private bool connectivity;
        public bool Connectivity
        {
            get { return Connectivity; }
            set { Connectivity = value; }
        }

        private string sensorData;
        public string SensorData
        {
            get { return SensorData; }
            set { SensorData = value; }
        }

        public Sensor(int type, string name)
        {
            this.SensorType = type;
            this.SensorName = name;
            Connectivity = true;
        }

        public string toString()
        {
            return "Sensor Type:" + SensorType + ", Sensor Name: " + SensorName + ", Connectivity: " + Connectivity;
        }
    }
}