using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Reminder
    {
        private Patient patient;
        public Patient Patient
        {
            get { return patient; }
            set { value = patient; }
        }

        private DateTime remindingTime;
        public DateTime RemindingTime
        {
            get { return remindingTime; }
            set { value = remindingTime; }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { value = message; }
        }

        public Reminder(Patient patient, DateTime date, string message)
        {
            Patient = patient;
            RemindingTime = date;
            Message = message;
        }
    }
}