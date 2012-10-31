using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Sensor
    {
        private enum SensorTypes { HEART_RATE, BLOOD_PRESSURE, TEMPERATURE, FAIL_STATUS, GPS };

        private int sensorType
        {
            get { return sensorType; }
            set { sensorType = value; }
        }
        private string sensorName
        {
            get { return sensorName; }
            set { sensorName = value; }
        }
        private bool connectivity
        {
            get { return connectivity; }
            set { connectivity = value; }
        }
        private string sensorData
        {
            get { return sensorData; }
            set { sensorData = value; }
        }

        public Sensor(int type, string name)
        {
            this.sensorType = type;
            this.sensorName = name;
            connectivity = true;
        }

        public string toString()
        {
            return "Sensor Type:" + sensorType + ", Sensor Name: " + sensorName + ", Connectivity: " + connectivity;
        }
    }
}