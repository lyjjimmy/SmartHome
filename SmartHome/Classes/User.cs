using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHome.Classes
{
    public class User
    {
        //Internal username
        public int userID
        {
            get { return userID; }
            set { userID = value; }
        }

        //What kind of user this is (Medical staff, patient, etc.)
        public int userType //Make protected?
        {
            get { return userType; }
            set { userType = value; } 

        }

        //Username used by the user to login
        public string userName
        {
            get { return userName; }
            set { userName = value; }

        }

        //Contains the encrypted version of the password created by the one-way hashing
        protected string userPassword //Either make type byte[length of hash] or make sure that the thing spits out a string of set size?
        {
            get { return userPassword; }
            set { /*Insert one-way hashing here*/ }
        }

        //User contact details ie. Phone number
        public string userContact
        {
            get { return userContact; }
            set { userContact = value; }
        }
    }
}