using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Sensor
    {
        public enum SensorTypes { HEART_RATE, BLOOD_PRESSURE, TEMPERATURE, FAIL_STATUS, GPS };

        private int sensorType;
        public int SensorType
        {
            get { return sensorType; }
            set { sensorType = value; }
        }

        private string sensorName;
        public string SensorName
        {
            get { return sensorName; }
            set { sensorName = value; }
        }

        private bool connectivity;
        public bool Connectivity
        {
            get { return connectivity; }
            set { connectivity = value; }
        }

        private string sensorData;
        public string SensorData
        {
            get { return sensorData; }
            set { sensorData = value; }
        }

        public Sensor(int type, string name, string initialValue)
        {
            this.SensorType = type;
            this.SensorName = name;
            this.SensorData = initialValue;
            Connectivity = true;
        }

        public string toString()
        {
            return "Sensor Type:" + SensorType + ", Sensor Name: " + SensorName + ", Connectivity: " + Connectivity;
        }
    }
}