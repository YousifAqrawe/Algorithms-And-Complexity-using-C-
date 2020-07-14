
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yousif_Community_Library_Software_Application // the namespace of the assignment 
{
    public class Member
    // the Class Member  contains the details of the Member and these include : FirstName, LastName, Username (set of firstname+ lastname)
    // the password and Telephone number of the number
    {
        // What i did is : I have generated the Getter and setter which is called the Auto-properties. Firstly, I have created Private string or (int) and
        // then I assigned these private strings (ints) into public String (int) somthings, which getting the return of the private function and set the value
        // of that private string or int

        public string Member_USERNAME // getter and setter for username is lastname of member then firstname of that member
        {
            get
            {

                /* the reason of why we returned the lastname of member then the forstname is : In our assignment, to login to member 
                we require to add the username as LastName+FirstName 
                */
                return  Member_LASTNAME + Member_FIRSTNAME;
            }
            set
            {
                  //Member_LASTNAME + Member_FIRSTNAME = value;
            }
        }
        //create private string for password of member
        private string member_password;
        public string Member_PASSWORD 
        {
            get
            {// get return the password of member 
                return member_password;
            }
            set
            {//then we set the password of member to be a value
                member_password = value;
            }
        }

        //create private string for the firstname of the member
        private string member_firstName;
        public string Member_FIRSTNAME
        {
            get
            {// get return the firstname of the member 
                return member_firstName;
            }
            set
            {//then we set the firstname of member to be a value
                member_firstName = value;
            }
        }
        //create private string for the lastname of the member
        private string member_lastname;

        public string Member_LASTNAME
        {
            get
            {// get return the lastname of the member 
                return member_lastname;
            }
            set
            {//then we set the lastname of member to be a value
                member_lastname = value;
            }
        }
        //create private string for the address of the member
        private string member_address;
        public string Member_ADDRESS
        {
            get
            {// get return the address of the member 
                return member_address;
            }
            set
            {//then we set the address of member to be a value
                member_address = value;
            }

        }
        //create private int for the phone number of the member
        private string member_phoneNumber;
        public string Member_PHONENUMBER
        {
            get
            {// get return the phone number of the member 
                return member_phoneNumber;
            }
            set
            {//then we set the phone number of member to be a value
                member_phoneNumber = value;
            }
        }
        private string[] How_many_Borrow_Yet; // create an array call How_many_Borrow_Yet to use it to create an object and assign num 10 as it maximum num of
                                                // borrowing
        private int Whole_Num_Of_Borrow;
        private int Actural_Borrow = 10;// this used inside the array if the array [] How_many_Borrow_Yet


        // create method to assign the information that we have added before to our parameters to show it to the 
        public Member(string Member_firstName, string Member_lastname, string Member_address, string Member_phoneNumber, string Member_password  //string How_many_Borrow_YET
            )
        { //one of private string (int) = one of parameters
          /*the member firstname*/       member_firstName = Member_firstName;      //is equal to parameter Member_firstName
          /*the member lastname */       member_lastname = Member_lastname;        //is equal to parameter Member_lastname
          /*the member address  */       member_address = Member_address;          //is equal to parameter Member_address
          /*the member cintact number*/  member_phoneNumber = Member_phoneNumber;  //is equal to parameter Member_phoneNumber
          /*the member password*/        member_password = Member_password;        //is equal to parameter Member_password

            How_many_Borrow_Yet = new string[Actural_Borrow]; //creating an object to say that we have 10 max borrowing
            Whole_Num_Of_Borrow = 0;
        }

       

        protected string successful_Of_Borrowing = "So far, The Member has borrowed :";//
        protected string faild_Of_Borrowing = "You have not borrowed movie yet.\n";
        protected string Ability_to_Borrow = " if you have registered, then you can borrow.";
        public void showing_what_we_borrowed()
        {
            if (Whole_Num_Of_Borrow < Actural_Borrow) // if the maximum number of borrowing is more than 10
            {
                if (Whole_Num_Of_Borrow > 0) // then we start with considering that the maximum number of borrowing is more than 0
                {                           // then we print the message of successful_Of_Borrowing the member borrowed specific movie 
                    Console.WriteLine(successful_Of_Borrowing); // we use Console.WriteLine to do this

                    int A_Number; // creating an integer call a number 
                    for (A_Number = 0; A_Number < Whole_Num_Of_Borrow; A_Number++) 
                    {// then we print the object that we have created previously in Member Method  and the number of time we borrowed 
                        Console.WriteLine(How_many_Borrow_Yet[A_Number]); // using the Console.WriteLine (the new object and array A_Number)
                        //break;
                    }
                }
                //but if our whole b=number is less than zero :
                else if (Whole_Num_Of_Borrow < 0)

                {// print the message saying that the you need to register if no borrow or no movie 
                    Console.WriteLine(Ability_to_Borrow); // using the Console.WriteLine as well.
                }

            }
            else {// else print that is faild
                Console.WriteLine(faild_Of_Borrowing);
            }

        }

       
        // methid to see that the borrow title of the movie has borrowd already
        public bool Successfully_borrowed(string TITLE_Of_Movie)
        {
            // creating an integer to add it to our for loop:
           int number_for_borrow;
            // we say that for number_for_borrow is less than the whole number of borrow:
            for ( number_for_borrow = 0; number_for_borrow < Whole_Num_Of_Borrow; number_for_borrow++)
            { //then if the array of the borrow is match the title of the movie
                if (How_many_Borrow_Yet[number_for_borrow] == TITLE_Of_Movie)
                {// we say that this is borrowed 
                    return true;
                }
            }
            // otherwise it is borrowed before
            return false;// that is why we return flase 
        }

        //Method to show what we have borrowed:
        public int What_borrowd_From_Parameter(string TITLE_Of_Movie)
        {
            // we create the integer num for borrow that we need to use it in our for loop :
            int number_for_borrow;
            // for this integer is less that the number of the borrow then:
            for (number_for_borrow = 0; number_for_borrow < Whole_Num_Of_Borrow; number_for_borrow++)
            {//if the array of the number for borrrow is created to match the title of the movie:
                if (How_many_Borrow_Yet[number_for_borrow] == TITLE_Of_Movie)
                {//then we return the member for borrow
                    return number_for_borrow;
                }
                // but if the array of the number for borrrow is created to not match the title of the movie:
                else if (How_many_Borrow_Yet[number_for_borrow] != TITLE_Of_Movie)
                {//return nothing
                    return 0;
                }
            }
            return -1; //return the things to be either correct or not
        }



        // making the borrow from the member for the title of the movie: 
        public void Doing_theBorrow(string TITLE_Of_Movie)
        {//to do the borrow stuffs, we need to say that the array that is not even borrowed yet is equal to the title of the movie
           How_many_Borrow_Yet[Whole_Num_Of_Borrow] = TITLE_Of_Movie;
           // and if that happens, we'll increase the whole number of borrow by 1
                Whole_Num_Of_Borrow = Whole_Num_Of_Borrow + 1;
            }



        // making the Return from the member for the title of the movie: 
        public void Doing_theReturn(string TITLE_Of_Movie)
        {
            // we created an integer says that make the return is equal to the wat we borrowed from parameter Title_Of_Movie
            int Make_Return = What_borrowd_From_Parameter(TITLE_Of_Movie);
            // and while is that integer is less that the Whole_Num_Of_Borrow by decreasing 1 value:
            while ( Make_Return < Whole_Num_Of_Borrow - 1)
            {// then we say that the array of our borrow yet increased by one value
                How_many_Borrow_Yet[Make_Return] = How_many_Borrow_Yet[Make_Return + 1];
            }
            // and then we decrease the number of the borrow if we have borrowed the movie
            Whole_Num_Of_Borrow = Whole_Num_Of_Borrow - 1;
        }

    }
}
