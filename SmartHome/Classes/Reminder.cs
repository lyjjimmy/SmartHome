using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class Reminder
    {
        private Resident resident;
        public Resident Resident
        {
            get { return resident; }
            set { value = resident; }
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

        public Reminder(Resident resident, DateTime date, string message)
        {
            Resident = resident;
            RemindingTime = date;
            Message = message;
        }
    }
}