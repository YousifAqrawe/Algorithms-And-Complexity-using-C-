using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yousif_Community_Library_Software_Application
{// class of Member Collection
    public class MemberCollection
    {

        // create an integer private calls the total array which we gonna use it in our methods:
        private int The_Total_Array;

        // create member collection that is used to: 
        public MemberCollection()
        {//1. create an object for our private Member Arra that we have created before this method and 
            // we say that this is equal to an array of Member 
            Get_Array_class_Member = new Member[25];// it can be any number
            // we give the total array to be 0
            The_Total_Array = 0;
        }

        // method to create the logic of adding an member from ember class
        public void Logic_of_InsertionMember(Member From_MemberCS)
        {// and we say that the private integer array  the total array  is gonna equal to our patameter 
            Get_Array_class_Member[The_Total_Array] = From_MemberCS;
            // and by that we increaseing the total array by 1
            The_Total_Array = The_Total_Array + 1;
        }

        // create private Array which is grabing the array from Member class:
        private Member[] Get_Array_class_Member;

        // method of signing in by usng the username if the member and the password  
        public Member Making_Sign_in(string MEMBER_Username, string MEMBER_Password)
        {
            // initialise an integer from zero
            int Our_Meber = 0;
            // and if the zero is less than the total array then:
            while (Our_Meber < The_Total_Array)
            {
                // if the get the array of the class member has username:
                if (Get_Array_class_Member[Our_Meber].Member_USERNAME.Equals(MEMBER_Username))
                {// we return the array class member for the Our Member
                    return Get_Array_class_Member[Our_Meber];
                }
                // and also if the get the array of the class member ahs password:
                else if (Get_Array_class_Member[Our_Meber].Member_PASSWORD.Equals(MEMBER_Password))
                {
                    return Get_Array_class_Member[Our_Meber];
                }
            }
            //if it not correct we renturn nothing
            return null;
        }

     
      

        // create a method that we can get the contact phone number from the first name and last name:
        public Member GetPhFirstLastName(string MEMBER_FirstName, string MEMBER_LastName)
        {// initialise an integer calls  Method to 0
            int Method;

            for (Method = 0; Method < this.The_Total_Array; Method++)
            // while zero less than the total array:
            {
                //If the get the array of the class member [0] has the correct first name and also last name then :
                if (Get_Array_class_Member[Method].Member_FIRSTNAME.Equals(MEMBER_FirstName) && (Get_Array_class_Member[Method].Member_LASTNAME.Equals(MEMBER_LastName)))
                {// we return that array to be implemented and initialised from 1
                    return Get_Array_class_Member[Method];
                }

            }


            // return null to get it work
            return null;

        }
        // create a methiod sayibg that the Member has already enrolled 
        public bool HasEncroledBefore(string MEMBER_FirstName, string MEMBER_LastName)
        {
            int He_Has_Enrolled = 0;
            //for (He_Has_Enrolled = 0; He_Has_Enrolled < The_Total_Array; He_Has_Enrolled++)
            while (He_Has_Enrolled < The_Total_Array)
            {
                // if the get the array of the class member ahs First name and Last anme :

                if (Get_Array_class_Member[He_Has_Enrolled].Member_FIRSTNAME.Equals(MEMBER_FirstName) &&
                         Get_Array_class_Member[He_Has_Enrolled].Member_LASTNAME.Equals(MEMBER_LastName))

                {// make this to be returned
                    return true;
                }

            }
            // if not he might hasn't enrolled then he can make sign in
            return false;
        }
    }
}