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
        protected int userType
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

        //Contains the encrypted version of the password created by the md5 hash of the password itself.
        protected string userPassword //Either make type byte[length of hash] or make sure that the thing spits out a string of set size?
        {
            
            get { return userPassword; }
            set { userPassword = computePasswordHash(value); }
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
                this.userPassword = computePasswordHash(userPassword);
                this.userContact = userContact;
                return "User account successfully created";
            }
            

            //Logically will never reach this section of the code, but needed anyway as default return.
            return "Unknown error occurred in account creation";
        }

        //Computes the one-way hash from the input given and returns it as a string
        public string computePasswordHash(string password)
        {
            string hash;
            MD5 md5Hash = MD5.Create();
            byte[] input = System.Text.Encoding.UTF8.GetBytes(password);
            md5Hash.ComputeHash(input);
            hash = md5Hash.Hash.ToString();
            return hash;
        }
    }
}