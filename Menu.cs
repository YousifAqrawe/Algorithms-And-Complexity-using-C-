
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Yousif_Community_Library_Software_Application
{
    class Menu
    {

        private static MovieCollection Get_Access_From_movieCollection;
        private static MemberCollection Get_Access_From_memberCollection;
        private static Member Get_Access_From_MemberCS;
        public static void Welcome_msgg()
        {
            string Welcome_message = "\n\nWelcome to Yousif's Community Library Software Application";
            Console.WriteLine(Welcome_message);
        }

        static void Main(string[] args)
        {
            Welcome_msgg();


            // public static void Menustuffs()
            // {

            // create new objects which are to get access from the both Movie Collection class and Member Collection
            Get_Access_From_movieCollection = new MovieCollection(); // create an object which is to store the 
            Get_Access_From_memberCollection = new MemberCollection();
          //  Get_Access_From_MemberCS = new Member();

            string Menu_Is_Main = "Main Menu";
            int selectNumFromFollowings = -1;
            while (true)
            {

                string Adding_MenuMain_Requirements = "===========" + Menu_Is_Main + "============\n"
                                                      +/* 1- */ "1- Staff Login\n" //click 1 then we need to add staf123 for user name and today123 for password
                                                      +/* 2-*/ "2- Member Login\n" // Click 2 login as username and password. the username (lastname + firsyname) a
                                                                                    //and the password has 4 digit numbers but first we need to login in staff to register the 
                                                                                    //member details to be able to work on our situation here
                                                      +/* 0- */ "0- Exit\n"         // Click on 0 to close the console screen  (Exit the program)
                                                      + "================================\n";
                // create for selection of the 3 things above so we can make the selection between the 3 things 1, 2 or (3 to exit)
                string make_selection = " Please make a selection ( 1 - 2, or 0 to exit ): "; 




                // printning out the thi
                Console.WriteLine(Adding_MenuMain_Requirements);
                selectNumFromFollowings = Adding_num_to_Text(make_selection, 0, 2);
               // while ((selectNumFromFollowings > Adding_num_to_Text(make_selection, 0, 2)) || (selectNumFromFollowings < Adding_num_to_Text(make_selection, 0, 2)))
               // {
               //     Console.WriteLine("You have to choose one of the following numbers 1, 2 or 0");
               //         break;
               //
               // }
                if (selectNumFromFollowings == 0)
                {
                    break;
                }
                // if we say that we selected 1 or 2 then:
                if (selectNumFromFollowings == 1 || selectNumFromFollowings == 2)
                {//we have already created a string says that to enter the username of the member or staff
                    string Add_your_ID_Text = "Please Enter your UserName: ";
                    // also it asks to enter the password of the username  staff or member
                    string Add_your_password_Text = "Please Enter your Password: ";
                    // after that we add the console.Write for username of both member and staff
                    Console.Write(Add_your_ID_Text);
                    // then we need to write the message of the username
                    string Insert_the_id = Console.ReadLine();
                    // also 
                    Console.Write(Add_your_password_Text);
                    string Insert_thePasscode = Console.ReadLine();
                    // Insert_thePasscode = "staff"; // the username must alsways value equals to 'staff'
                    // Insert_thePasscode = "today123"; // the password must always has value equals to 'today123'
                    if (selectNumFromFollowings == 1)
                    { /*
                        As noted in the assignment specification, the username must be staff and the password must be today123
                        so I created 2 if statement:
                         */

                        /*
                         the first If statement which is saying if our username and password are both correctly typed
                         */
                        if ((Insert_the_id == "staff") && (Insert_thePasscode == "today123"))
                        {
                            /*
                             We get the Confirmation_successfully_login message and from that we can go to the Staff Menu (Details_of_Menu_of_staff_)
                             */

                            // the Confirmation_successfully_login is:
                            string Confirmation_successfully_login = "\nGreat! You have access now on Staff Menu and you can Add Movies," +
                                                                    " remove Mocies, register members and find member's phone number\n";
                            // the way i inserted the Confirmation_successfully_login message is usiing Console.WriteLine;
                            Console.WriteLine(Confirmation_successfully_login);
                            // then go to Staff Menu
                            Details_of_Menu_of_staff_();



                        }

                        /*
                         But, if our username or password are incorrect, this means it is impossible to complete the process and we need to go back
                         our main menu login to add the correct username and password 
                         */

                        // so if our usernamw or/and is not correct:
                        else if ((Insert_the_id != "staff") || (Insert_thePasscode != "today123"))
                        {
                            // we print a message saying that our username or password are not correct then we go to main menu to login again
                            string wrongID_Password = "\n Sorry, the username or password are not correct. Please try Again!\n";
                            //also the way i did the printing stuffs is using the console.WriteLine();
                            Console.WriteLine(wrongID_Password);
                            
                        }// end else if (wrong username or password)

                    }// end  if (selectNumFromFollowings == 1)

                    /*
                    So, if we choose num 2 and this means we need to lohin to Member with a note that we need to register first from
                    staff menu and then we are able to login for member
                     */
                    if (selectNumFromFollowings == 2)
                    {
                        /* because we have create objects here, that gives us the access to use the method that are available in Member class
                         to use it here as well as the other class. so in here i use the object Get_Access_From_MemberCS and it is done by getting
                         access from member collection to go to Making_Sign_in and add the Making_Sign_in method and by that we can add
                         username and password
                        */
                        Get_Access_From_MemberCS= Get_Access_From_memberCollection.Making_Sign_in(Insert_the_id, Insert_thePasscode);

                        
                        if (Get_Access_From_MemberCS == null)
                        {
                           // Details_Of_Menu_Of_Member();
                            Console.WriteLine("\n Unfortunately! The Username or Password are not correct. Please try again with correct username and password\n");
                           // break;
                            // 
                        }

                        else if (Get_Access_From_MemberCS != null)
                        {
                            string Confirmation_successfully_login = "\nGreat!You have access now on Member Menu and can Display All Movies," +
                                                                     "borrow movies, return movies, List Borrowed Movies and display top 10 popular movies  \n";
                            Console.WriteLine(Confirmation_successfully_login);
                            Details_Of_Menu_Of_Member();
                            //  Console.WriteLine("Sorry, the username or password you have entered are incorrect. Please try Again!" + "\n");

                        }

                    }
                }
                


                

            }
        }


        private static void Details_of_Menu_of_staff_()
        {
            string Menu_Is_staff = "Staff Menu";// the name of our menu is staff menu
            int selectNumFromFollowings = -1;
            string staff = "=========== " + Menu_Is_staff + " ============"; // the name of our menu is Staff Menu


            string adding_Staff_requirements = "\n"
                                              + "1- Add a new movie DVD" + "\n"                 // the message that we can add a movie (click 1 to do that)
                                              + "2- Remove a movie DVD" + "\n"                  /* the message that we can delete a movie that we
                                                                                                created previously click 2 to do that*/
                                              + "3- Register a new Member" + "\n" // Sign up for new member by clicking on 3 to do that
                                              + "4- Find a registered member's phone number" + "\n" // this message allows us to see what is the phone
                                                                                                    //number of the member after we add the first and lastname\
                                                                                                    //of the member that we created. by clicking on num 4
                                              + "0- Return to main menu" + "\n" // click on 0 to return to our Maon Menu
                                              + "===================================\n";
            // after that we add the messages together by using the  Console.WriteLine
            Console.WriteLine(staff + adding_Staff_requirements);

            /* this message will be added to selectNumFromFollowings*/
            string make_selection_for_staff = (" Please make a selection (1 - 4 or 0 to return to main menu): ");

            /*
             the selectNumFromFollowings here has 3 parts:
            firdt, Adding_num_to_Text which is by it we can select the numbers
            Second is adding the message of make_selection_for_staff 
             third  one is we can select from 0 to 4
             */
            selectNumFromFollowings = Adding_num_to_Text(make_selection_for_staff, 0, 4);
            // ehile our number selection is not zero which is (not going to the main menu:)
            while (selectNumFromFollowings != 0)
            //for (int i = 0; i < length; i++)

            {

                if (selectNumFromFollowings == 1) // if we choose number 1
                {
                    InsertionForOurMovie(); // we make the adding for a movie DVD
                    break; //  break here means after we finish we go to Main menu (main loigin message)
                    //break;
                }
                else if (selectNumFromFollowings == 2)// if we choose number 2
                {
                    Deletion_Of_movie(); // we make the removing for a movie DVD that created before
                    break; // also going back to main menu
                }
                else if (selectNumFromFollowings == 3) // if we choose number 3
                {
                    Add_the_info_member(); // we add the information of our member
                    break; // also going back to main menu
                }
                else if (selectNumFromFollowings == 4) // if we choose number 4
                {
                    Getting_the_member_from_PH();// we add the member firstname and lastname to get the contact number
                    break;  // also going back to main menu
                }


            }
        }
           
        private static void InsertionForOurMovie()
        {

            int WHAT_IS_CLASSIFICATION, WHAT_IS_GENRE = 0;
            //int  = 0;
            // message of title is going to be :F
            string the_Titile_Text = "\nPlease add the Title of the Movie: ";
            // message of Starring is going to be :
            string the_Starring_Text = "Please enter the Starring Actor (Actors): ";
            // message of Starring is going to be :
            string the_Directir_Text = "Please enter the Director (Directors): ";
            // message of Genre is going to be :
            string the_genre_Text = "Please choose the Genre from the following 8 Gemres: ";
            // message of Classification is going to be :
            string the_classufucation_Text = "Please choose the Classification from the following 4 classification: ";

            string GENRE_choosing = "Please choose the Genre by making the selection (1-8): ";
            string[] Slelect_classifications = {/*1- */"General (G)",// pressing on 1 will choose General Classification of the movie
                                        /*2- */"Parental Guidance (PG)",// Pressing on 2 will choose the PG Classification of the movie
                                        /*3- */"Mature (M15+)", // choosing 3 will choose the M15+ Classification of the Movie
                                        /*4- */"Mature Accompanied (MA15+)"// pressing on 4 will choose MA15+ classification of the Movie
                                        }; 
//
            Console.Write(the_Titile_Text);
            string TITLE_Of_Movie = Console.ReadLine();
            Console.Write(the_Starring_Text);
            string STARRING_of_Movie = Console.ReadLine();
            Console.Write(the_Directir_Text);
            string Who_isAreDIRECTOR_of_Movie = Console.ReadLine();
            Console.WriteLine(the_genre_Text);
            //   genres.Length = 8;

            // what is the genre that our software has? we have 7 types of genre and 
            //if we don't want any of these 7 we can choose num 8 which choosing other films.
            string[] GENRE_Of_Movie = { /*1- */" Drama Movie", // click 1 to select Drama
                                        /*2- */ " Adventure Movie",//click 2 to select Adventure
                                        /*3- */ " Family Movie",   //click 3 to select Family
                                        /*4- */ " Action Film",    //click 4 to select Action
                                        /*5- */ " SciFi movie",    //click 5 to select SciFi
                                        /*6- */ " Comedy Movie",   //click 6 to select Comedy
                                        /*7- */ " Thriller Movie", //click 7 to select Thriller
                                        /*8- */ " Other Movies" }; //click 8 to select Other type of movies

            for (int Num_of_increasingGenre = 0; Num_of_increasingGenre < GENRE_Of_Movie.Length; Num_of_increasingGenre++)
            {
                int make_the_Genre_Increasing = Num_of_increasingGenre + 1;
                Console.WriteLine((make_the_Genre_Increasing).ToString() + "- " + GENRE_Of_Movie[Num_of_increasingGenre]);
            }
            

            WHAT_IS_GENRE = Adding_num_to_Text(GENRE_choosing, 0, 8);
            Console.WriteLine(the_classufucation_Text);
            int Classification_oreders = 0;
            for (Classification_oreders = 0; Classification_oreders < Slelect_classifications.Length; Classification_oreders++)
            {// conver it to string then add the symbol - and here we use array
                Console.WriteLine((Classification_oreders + 1).ToString() + "- " + Slelect_classifications[Classification_oreders]);
            }


            string the_Classificaion_Text = "PLease choose the Classifivation by Making selection (l-4): ";
            string the_Duration_Text = "Please enter the duration of the movie: ";
            string the_data_released_Text = "Please enter which year movie released: ";
            string copy_text = "Please enter the number of Copies Available: ";
            string satisfactory_added = "Great! the Movie " + "'" + TITLE_Of_Movie + "'" + " has successfully be added. \n";
            string already_added = "Unfortunatily, the Movie " + "'" + TITLE_Of_Movie + "'" + "was already added before!\n";

            WHAT_IS_CLASSIFICATION = Adding_num_to_Text(the_Classificaion_Text, 1, 4);
            int duration_of_single_film_From = 10;
            int duration_of_single_film_to = 400; //this is the duration of a single movie . 
                                            //Ihave selected 400 as the maximum movie is going to be at most 5 hours
            int Minuts_Duration = Adding_num_to_Text(the_Duration_Text , duration_of_single_film_From, duration_of_single_film_to);


            int Release_range_from = 1888; // the first film in the world has meen released in 1888 that is why i've ranged the release range of
                                            // a movie from 1888
            int Release_range_to = 2020;   // Because we now in 2020, the last film has released in this year . no more than this
            int When_Movie_release = Adding_num_to_Text(the_data_released_Text, Release_range_from, Release_range_to);
            int How_many_copies_available_in_our_Software_from = 0; // the range of how many copies available starts from zero
            int How_many_copies_available_in_our_Software_to = 1000;// the range of how many copies available ends to 1000 so no more than this to be available
                                                                    // in our software

            //How_Many_copies_Available includes the way of maiking the selection , the copy Message (range)
            int How_Many_copies_Available = Adding_num_to_Text(copy_text, How_many_copies_available_in_our_Software_from, How_many_copies_available_in_our_Software_to);


              if (Get_Access_From_movieCollection.Put_A_Movie(new Movie(TITLE_Of_Movie, STARRING_of_Movie, Who_isAreDIRECTOR_of_Movie, 
                  GENRE_Of_Movie[WHAT_IS_GENRE -1], Slelect_classifications[WHAT_IS_CLASSIFICATION - 1], Minuts_Duration, When_Movie_release, How_Many_copies_Available, 0))) 
                  //0 means the time rented starts with 0 which is no one took the movie yet and it will increase depends on how many borrowed 
            {
                //print us the message satisfactory_added
                Console.WriteLine(satisfactory_added);
                //Details_Of_Menu_Of_Member();
            }

            ///if //(!(Get_Access_From_movieCollection.Put_A_Movie(new Movie(TITLE_Of_Movie, STARRING_of_Movie, DIRECTOR_of_Movie, GENRE_Of_Movie[WHAT_IS_GENRE - 1], classifications[WHAT_IS_CLASSIFICATION - 1], duration, releaseDate, copiesAvailable, 0)))
            else
            {// this means the film has already added
                Console.WriteLine(already_added);
            }

           // then go to staff menu again after we finish
           Details_of_Menu_of_staff_();

        }
        // create a method calls Deletion_Of_movie which helps to delete the movie that we have created
        private static void Deletion_Of_movie()
        {// create a string calls Deletion_MSG which is used to show the message of the 
          //deletion that we use it to enter title tp make a deletion
            string Deletion_MSG = "Please Enter the movie title to delete it ";
            // we use the Consol.Write to add the Deletion_MSG into it
            Console.Write(Deletion_MSG);
            // after that we create a string calls Insert_The_TITLE to make the deletion
            string Insert_The_TITLE = Console.ReadLine();

            // after that we say if the method Make_The_Deletion_For_AMovie which is accessed from Movie Collection Class has had the right
            //title, then:
            if (Get_Access_From_movieCollection.Make_The_Deletion_For_AMovie(Insert_The_TITLE))
            {
                //we print a message says that the title of the movie is successfully deleted
                Console.WriteLine("Great! the Movie " + "'" + Insert_The_TITLE + "'  has been Successfully deleted.\n");
                //And after that we go to staff menu method
                Details_of_Menu_of_staff_();
            }
            // if that is not correct (which means either it has deleted already or it is not valid movie)
            else//if (!Get_Access_From_movieCollection.DeletionForOurMovie(title))
            {// so if that doesn't exist or already deleted, then we write this message  and we need to use also (Console.WriteLine)
                Console.WriteLine("Unfortunitaly! the Movie" + "'" + Insert_The_TITLE + "' hasn't been added already! Please delete a valid movie\n");
            }
        }

        // create a method for member menu to add info to it:
        private static void Add_the_info_member()
        {  // creating a string for adding message for adding the first name
            string Member_FirstNameMSG = "Please enter your first name: ";
            // creating a string for adding message for adding the Last name
            string Member_LastNameMSG = "Please enter your last name: ";
            // creating a string for adding message for adding the address for the member
            string Member_AddressMSG = "Please enter your Address: ";
            // creating a string for adding message for adding the contact number of the member
            string Member_PH_MSG = "Please enter Phone Number: ";
            // creating a string for adding message for adding the password which is should be 4 digits only (not more or less)
            string Member_password = "Please Enter your 4 digit for password(4 digits): ";
            
            
            // if our first and last name correctly added, then we get this message 
            string suceessfully_Added_FLName_MSG = "Great! You have Successfully been adding ";
            // if our first and last name has already added, then we get this message 
            string Already_Added_FLName_MSG = "was being added before! Please try with another firstname and lastname \n";
            //    string W = "Enter member's Password:";

            //we print the first name of member correctly and we need to use the Consol.Write
            Console.Write(Member_FirstNameMSG);
            // create a string member first name to be able to write the member firstname
            string Member_firstName = Console.ReadLine();
            //we print the last name of member correctly and we need to use the Consol.Write
            Console.Write(Member_LastNameMSG);
            // create a string member last name to be able to write the member lastname
            string Member_lastname = Console.ReadLine();
            // after that we need to say if our firstname and lastname haven't been enrolled before then:
            if (!Get_Access_From_memberCollection.HasEncroledBefore(Member_firstName, Member_lastname))
            {
                // we continue our method saying that print me the address message 
                Console.Write(Member_AddressMSG);
                // then we need to add the address for the member using the string Member_address and console.ReadLine()
                string Member_address = Console.ReadLine();
                // we add the contact number message saying that by using the Console.Write and message of the conact number
                Console.Write(Member_PH_MSG);
                // then we write the number of member's phone
                string Member_phoneNumber = Console.ReadLine();
                // if we say that our password is something:
                string Our_Passcode_Is = "";
                //then while password is not that something to add then: 
                while (!MAKE_The_Password(Our_Passcode_Is))
                {
                    // then we print out the password using the password msg and of course we use the console.WriteLine
                    Console.Write(Member_password);
                    // the we say that we need to type the password  using the Console.ReadLine() 
                    Our_Passcode_Is = Console.ReadLine();
                }
                // then we do the instruction of how we gonna make the steps of what would display:
                // and basically to dd that, we get the access from the Member collection class to go to the method Logic_of_InsertionMember and
                //grap the information of member firstname, lastname password, phone number , address and phone number
                Get_Access_From_memberCollection.Logic_of_InsertionMember(new Member(Member_firstName, Member_lastname, Member_address, Member_phoneNumber, Our_Passcode_Is));
                // after that we print out the message of suceessfully_Added_FLName_MSG and we include the firstname and lastname as well.
                string Full_Name = Member_firstName + " " + Member_lastname+ "\n";
                Console.WriteLine(suceessfully_Added_FLName_MSG + Full_Name);
               // Menustuffs();
            }
            else //if (Get_Access_From_memberCollection.HasEncroledBefore(Member_firstName, Member_lastname))
            { // if it is already exist:
                string Full_Name = Member_firstName + " " + Member_lastname;
                // we print out the Already_Added_FLName_MSG following by the full name of the member
                Console.WriteLine(Full_Name + Already_Added_FLName_MSG);
            }

        }
        // create a method for adding the firstname + lastname  -> getting the contact number of that member
        private static void Getting_the_member_from_PH()
        {
            // the message of our adding the firstname of member:
            string Member_FirstNameMSG = "\nPlease enter the Member FirstName: ";
            //the message of adding the lastname of the member:
            string Member_LastNameMSG = "Please enter the Member LastName: ";
            // the message when we found the contact number of that member:
            string Member_PH_MSG = "has phone number and it is: ";
            // The message if we haven't added the contact number of that member :
            string Member_Not_PH_MSG = "The Member's Phone Number hasn't been added. \n";
            // using the Console.Write to add the message of the adding the firstname
            Console.Write(Member_FirstNameMSG);
            // using the Console.ReadLine to be able to write the firstname of the member
            string Member_firstName = Console.ReadLine();
            // using the Console.Write to add the message of the adding the Lastname
            Console.Write(Member_LastNameMSG);
            // using the Console.ReadLine to be able to write the lastname of the member
            string Member_lastName = Console.ReadLine();

            // After that we getting the access from member class and by going to the method GetPhFirstLastName to add the
            // firstname and lastname of the member to get the phone number . so if that is not null then:
            // Member MemberClass = Get_Access_From_memberCollection.GetPhFirstLastName(Member_firstName, Member_lastName);
            Member From_Member = Get_Access_From_memberCollection.GetPhFirstLastName(Member_firstName, Member_lastName);
            if (From_Member != null)
            {
                // create a string of getting the phone number from the member username and we will see the firsname  + the lastname printed  
                // as well as the message of member phone number + the getting access from member class to grab the method of GetPhFirstLastName
                // to to show the phone number of that member.
                 
                // after that we ptint the result of what string phoneNumOfuser will be equal
                Console.WriteLine(Member_firstName + " " + Member_lastName + Member_PH_MSG
                    + Get_Access_From_memberCollection.GetPhFirstLastName(Member_firstName, Member_lastName).Member_PHONENUMBER + "\n");
            }

            // but, if that is being added :
            else //if (From_Member == null)
            {
                // we will print the message that says the message is already added and we use the console.WriteLine
                Console.WriteLine(Member_Not_PH_MSG);
            }
        }


        // this method to make sure that if the password is entered correctly
        private static bool MAKE_The_Password(string PASSWORD_Of_Member) 
        {
            // if we say that the length of our password is not equal to 4: 
            if (PASSWORD_Of_Member.Length != 4)
            {
                //this means the password is wrong and we need to typed again
                return false;
            }

            int Actual_passeord = 0;
            // but if the actual password is less than 4 which then:
            for (Actual_passeord = 0; Actual_passeord < PASSWORD_Of_Member.Length; Actual_passeord++)
            {
               // if (Actual_passeord < PASSWORD_Of_Member.Length)
           // {
                //for (int i = 0; i < Member_password.Length; i++)
                //{
                // we create another if statement saying that the character of isletter is (the password of array actual password)
                if (Char.IsLetter(PASSWORD_Of_Member[Actual_passeord]))
                {
                    //then also return false for that
                    return false;
                }
            }
            //if all these happened, so we return the value to be true
            return true;
        }

       

        // static method to make the mamber menu details
        private static void Details_Of_Menu_Of_Member()
        {

            int Select_For_Member_Menu;
            string Name_Of_ThisMenu = "\n\n ======== Member Menu ============\n"; // the name of this menu";
            string Adding_MenuMember_Requirements =     Name_Of_ThisMenu
                                                  + "1- Display all movies\n" // pressing  will show us the whole movies that we have added
                                                  + "2- Borrow a movie DVD\n" // pressing 2 will give us access to borrow the movie that we have added 
                                                  + "3- Return a movie DVD\n" //prssoing 3 will will give us access to return the movie that we have borrowed
                                                  + "4- List current borrowed movie DVDs" + "\n" // if we made borrow then we prss 4 to list the borrwed movie DVDs 
                                                  + "5- Display top 10 most popular movies\n" // if we have movies, then we can dipslay the top 10 movies by A_Z order so we press 5
                                                  + "0- Return to main menu\n" // pressing on 0 to go back to our main menu
                                                  + "=================================\n";

            Console.WriteLine(Adding_MenuMember_Requirements); // then print the member menu list that provides the the 5 things that i mentioed previously
            string make_selection = "\n Please make a selection(1 - 5 or 0 to return to main menu): "; // after we add the requirements of the member menu, we need to create a message 
                                                                                                       // saying we need to make selection to select on of things above
            Select_For_Member_Menu = Adding_num_to_Text(make_selection, 0, 5); // we need to make the selection from 1 to 5 . or if we wanna go to main menu we press 0

            while (Select_For_Member_Menu == 0)// so if we press on 0, we go back main menu
            {

                // Menustuffs();
                //   Details_Of_Menu_Of_Member();
                break;
            }
            while (Select_For_Member_Menu != 0) // but if we press on number that is not 0: 

              //the not zero means happens when we press numbers from 1 to 5 (but not zero)
            {
                // that means if we select on one we will see the all movies that we have added (these movies will be shown a_z oreder)
                if (Select_For_Member_Menu == 1)
                {
                   
                   // we go to movie collection class and grab the A_Z order
                    Get_Access_From_movieCollection.ShowEverything();// this is how to see the  the all movies by A_Z order process
                    Details_Of_Menu_Of_Member(); // return back to member menu
                    
                }
                //Also if we press on number 2 we go directly to make the borrow process
                else if (Select_For_Member_Menu == 2)
                {
                    The_Info_Of_Borrow();// this is the method that we have created to do the borrowing process
                   Details_Of_Menu_Of_Member();// then go back again to member menu after we finish
                }
               // Also if we press on number 3 we go directly to make the return process after we borrowed as well:
                else if (Select_For_Member_Menu == 3)
                {
                    Doing_theReturn();// this is the method that we have created to do the return process but first we need to borrow the movie
                    Details_Of_Menu_Of_Member();// then go back again to member menu after we finish
                }

                // Also if we press on number 4 we go directly to see the borrowed lists
                else if (Select_For_Member_Menu == 4)
                {
                    // showing_what_we_borrowed();
                    //Get_Access_From_MemberCS.showing_what_we_borrowed(); // this is the process to see the borrowed movies
                    //  listCurrentBorrowedMovieDVDs();

                    Get_Access_From_MemberCS.showing_what_we_borrowed();
                    Details_Of_Menu_Of_Member();// then go back again to member menu after we finish
                }
                // finally if we press on number 5 we go directly to see the top 10 popular movies :
                else if (Select_For_Member_Menu == 5)
                {
                    Console.WriteLine("\n================================="); // this is just to make it looks better look
                    Get_Access_From_movieCollection.DisplayT10();// we go to the Movie collection class and grab the method DisplayT10() to get it work
                    Console.WriteLine("===================================");
                    

                    Details_Of_Menu_Of_Member(); // then go back again to member menu after we finish
                }
                // if we finish all of the above, then we finish the making select is not 0  
                break; 
            }
          
        }


        // creating static method for the adding the borrowing stuffs:
        private static void The_Info_Of_Borrow()
        {// after we click on 2 we'll get this message saying that  we need to add the MOvie name to make the borrow
            string borrow_text = "Please enter the Movie title that you want to borrow: \n";
            //then we print out the text of borrow using the Consol.WriteLine as usual
            Console.Write(borrow_text);
            // add the title of the movie by writing it useing the Consol.ReadLine as well.
            string The_Title_Of_Mivie = Console.ReadLine();
            //if we say that we got access from the Member class and we went to the successfully borrowed mwthod but 
            //we borrowed the title of that movie before then:
            if (!Get_Access_From_MemberCS.Successfully_borrowed(The_Title_Of_Mivie))

            {
                // but if that was not borrowed before the:
                if (Get_Access_From_MemberCS.Successfully_borrowed(The_Title_Of_Mivie))
                {// we say that if we want to make the borrowe by getting access from Movie Collection class, then:
                    if (Get_Access_From_movieCollection.Make_the_Borrow(The_Title_Of_Mivie))
                    {
                        // we go then and say that it has sucessfully borrowed because it hasn't added before so we continue with our work
                        Get_Access_From_MemberCS.Successfully_borrowed(The_Title_Of_Mivie);
                        // after that we print out the message of the satisfactory message saying that we have bowed this title correctly
                        string satisfactory_borrow_MSG = "Great! You have Successfully borrowed " + "(" + The_Title_Of_Mivie + ")\n";
                        // then we show the result by writing the Console.WriteLine
                        Console.WriteLine(satisfactory_borrow_MSG);
                    }// end if (Get_Access_From_movieCollection.Make_the_Borrow(The_Title_Of_Mivie))
                }//end while (Get_Access_From_MemberCS.Successfully_borrowed(The_Title_Of_Mivie))
                else
                {// we print out a message saying that you need to borrow a movie that it hasn't been borrowed before
                    string already_borrowed = "Unfortunatilly!You borrowed movie(" + The_Title_Of_Mivie + " before)";
                    // after that we use the console.WriteLine to add the text.
                    Console.WriteLine(already_borrowed);
                }//end  while (!Get_Access_From_MemberCS.Successfully_borrowed(The_Title_Of_Mivie))

            }// end method private static void The_Info_Of_Borrow()
        }
            // this method we have created it to show that previous method has to be added correctly so we say that:
            private static void Applying_the_Result_After_Borrow_For_Movie()
        {// 1. adding the message of the satisfactory borrowed message that we say that this title has been borrwed
            string borrowingMSG = "Great! You have borrowed the (";
            // 2. adding the message of the Already borrowed message and the title has borrowed before already
            string norrowedAlreadyMSG = "You have already borrowed this movie.\n";
            // 3. this is the important message to see the entering of the movie message
            string TitleMSG = "Please enter the movie title: ";
            // agter we created these messages, we say that we want to see the TITLE message first to be able to add the movie
            // tile name
            Console.Write(TitleMSG);
            // then we say that our title of our movie has been entered so we have 2 possible things:
            string TITLE_Of_Movie = Console.ReadLine();
            //1. first possible thing is that the borrow has already taken from the member class:
            while (Get_Access_From_MemberCS.Successfully_borrowed(TITLE_Of_Movie))
            { // and while that happend we say this is already added and u need to add unborrowed movie 
                Console.WriteLine(norrowedAlreadyMSG);
            }// end  while (Get_Access_From_MemberCS.Successfully_borrowed(TITLE_Of_Movie))

            // but if that hasn't been borrowed before then we say that:
            while (!Get_Access_From_MemberCS.Successfully_borrowed(TITLE_Of_Movie))
            {
                // while this hasn't been borrowed before then:
                if (Get_Access_From_movieCollection.Make_the_Borrow(TITLE_Of_Movie))
                {// we do the borrow for that member name
                    Get_Access_From_MemberCS.Doing_theBorrow(TITLE_Of_Movie);
                    // then we get the message of the borrow message saying that we have  correctly borrowed this movie
                    Console.WriteLine(borrowingMSG + TITLE_Of_Movie + ")\n");
                } //end if (Get_Access_From_movieCollection.Make_the_Borrow(TITLE_Of_Movie))

            } // end while (!Get_Access_From_MemberCS.Successfully_borrowed(TITLE_Of_Movie))

        }// end method private static void Applying_the_Result_After_Borrow_For_Movie()


        // we need also to create a method for returning  the borrowed title
        private static void Doing_theReturn()
        {// so first of all, we create the messages that we want to show either it has returned or not (because it has not borrowed already)
            // 1. message of adding the title of the movie to return
            string return_the_movie = "\nPlease Enter the movie title that you want to return: ";
            // 2. message of the borrowe has already has not borrowed
            string Already_HasNot_Borrowed_Yet = "It seems like You have not borrowed this movie yet or you have borrowed it before." +
                                              " Make sure you borrow it before you make the return\n";
            // so we show the return message first :
            Console.Write(return_the_movie);
            // we add the movie title that we want to add:
            string Adding_MovieTitile = Console.ReadLine();
           // and then after we add the name of the title of the movie, we have 2 possible things:
           //1. the movie has already has not borrwed so we will not get the return of that movie
            if (!Get_Access_From_MemberCS.Successfully_borrowed(Adding_MovieTitile))
            {// so we'll get the message that it hasn't borrowed yet and please borrowe it first to get it returned:
                Console.WriteLine(Already_HasNot_Borrowed_Yet);
            }//end if(!Get_Access_From_MemberCS.Successfully_borrowed(Adding_MovieTitile))

            // but also while we have added the borrowed movie, so we'll get the it returned :
            else if (Get_Access_From_MemberCS.Successfully_borrowed(Adding_MovieTitile))
            {//getting the access from the member class to make the borrow available to return the movie
                Get_Access_From_MemberCS.Doing_theReturn(Adding_MovieTitile);
                // then we orint the message that says it has  successfully returned 
                string satisfactory_return_msg = "The Movie " + "(" + Adding_MovieTitile + ")" + " has been successfully returned\n";
                // we make it available to be shown
                Console.WriteLine(satisfactory_return_msg);
            }// end else if (Get_Access_From_MemberCS.Successfully_borrowed(Adding_MovieTitile))
        }// end Method private static void Doing_theReturn()




        // in this method we are thinking that adding numbers by using the integer selectNumFromFollowings
        // and without this method we can't make selection
        private static int Adding_num_to_Text(string the_text, int LessVAlue, int MostValue)
        {
            int selectNumFromFollowings = 0;// we initialised the selection to be 0
            bool GettingOver = false;// the we add a boolian variable calls GettingOver and we make it to have a value False
            while (!GettingOver)// we say that if this variable is true (ehich is not flase):
            {// we create an exception by using the try Catch:
                try // try:
                {// try to print the parameter the_text using the Console.WriteLine
                    Console.Write(the_text);
                    //then we need to convert the selection variable user input value from string to integer using 
                    // the convertion int.Parse folloeing by the Console.ReadLine() to be able to write 
                    selectNumFromFollowings = int.Parse(Console.ReadLine());
                    // if we say that the selection is gonna be more than and equal to the small value and also less than or equal
                    //to the hig value
                    if (selectNumFromFollowings >= LessVAlue && selectNumFromFollowings <= MostValue)
                    {// we return the value of the GettingOver to be true
                        GettingOver = true;
                    }
                    //otherwise, id os not:
                    else if (!(selectNumFromFollowings >= LessVAlue) && !(selectNumFromFollowings <= MostValue))
                    {// our work will be wrong
                        GettingOver = false;
                    }
                }// catch nothing
                catch // catch:
                {
                    //nothing need to be added 
                }
            }
            return selectNumFromFollowings;// we add the selection value 
        }
    }
}