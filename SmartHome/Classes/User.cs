using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

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
            set
            {
                MD5 dodgy = MD5.Create();
                //dodgy.ComputeHash(value, 0, value.Length);    
            }
        }

        //User contact details ie. Phone number
        public string userContact
        {
            get { return userContact; }
            set { userContact = value; }
        }

        public string addUser(int userType, string userName, string userPassword, string userContact)
        {
            bool userDetailsFine = true;
            /*Test for usernames being same as already entered into system
            foreach(User usersblah of What that userlist is)
                {
                    if(usersblah.userName = userName)
                    {
                        return false;
                    }
                }
            */

            //Check if user password is correct length
            if (userPassword.Length < 6)
            {
                return "Password length too short (shorter than 6 characters)";
            }

            //Check if user password contatins at least one letter, number and symbol. (alphanumsymbol)

            //Username 16 max no spaces, password 6 char, at least one letter, number and special, 
            if (userDetailsFine)
            {
                this.userID = 0; //Create new userid here
                this.userType = userType;
                this.userName = userName;
                this.userPassword = userPassword;
                this.userContact = userContact;
                return "User account successfully created";
            }

            return "Unknown error occurred in account creation";
        }
    }
}