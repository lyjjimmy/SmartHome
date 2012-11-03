using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHome
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DateTime reminderTime;
        //TODO Space reserve for doctor / carrer / operator object to retrieve their patient list
        
        //Something to test
        List<int> testIntList = new List<int>();
        //End something to test

        protected void Page_Load(object sender, EventArgs e)
        {
            dateTextLabel.Text = "";
            timeTextLabel.Text = "";
            //Something to test
            testIntList.Add(19);
            testIntList.Add(26);
            testIntList.Add(52);
            foreach (int i in testIntList)
            {
                patientDropList.Items.Add(i.ToString());
            }
            //end something to test
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            int year = datePicker.SelectedDate.Year;
            int month = datePicker.SelectedDate.Month;
            int day = datePicker.SelectedDate.Day;
            int hour = int.Parse(hourPicker.SelectedValue);
            int minute = int.Parse(minutePicker.SelectedValue);
            reminderTime = new DateTime(year, month, day, hour, minute, 0);
            dateTextLabel.Text = reminderTime.Date.ToShortDateString();
            timeTextLabel.Text = reminderTime.TimeOfDay.ToString();
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            patientDropList.ClearSelection();
            dateTextLabel.Text = "";
            timeTextLabel.Text = "";
            datePicker.SelectedDate = DateTime.Today;
            hourPicker.ClearSelection();
            minutePicker.ClearSelection();
            reminderMessageBox.Text = "";
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //TODO write code to submit the reminder to the server
            //     and notify the patient at specific time.
        }

        protected void hourPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void minutePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void datePicker_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}