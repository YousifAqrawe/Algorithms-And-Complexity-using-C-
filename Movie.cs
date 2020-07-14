

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yousif_Community_Library_Software_Application

{
    public class Movie
    {
        // adding the getter and setter for Movie details by creating:
        /*
         * 1. private + string (int) + something;
         * 2. public + string (int) + Something{
         *   get by returning the name of private ;
         *   set the name in the private to be a value;
         *   }
             */

        
        private string movie_Title; //create private string for title of the movie
        public string Movie_TITLE   // getter and setter for title of that Movie
        {
            get
            {// get return the title of movie 
                return movie_Title;
            }
            set
            {//then we set the title of the movie to be a value
                movie_Title = value;
            }
        }
        private string movie_Starring;//create private string for Starring of the movie
        public string Movie_STARRING  // getter and setter for Starring of that Movie
        {
            get
            {// get return the Starring of movie 
                return movie_Starring;
            }
            set
            {//then we set the starring of the movie to be a value
                movie_Starring = value;
            }

        }
        private string movie_Director;//create private string for Director of the movie
        public string Movie_DIRECTOR  // getter and setter for Director of that Movie
        {
            get
            {// get return the Director of movie 
                return movie_Director;
            }
            set
            {//then we set the Director of the movie to be a value
                movie_Director = value;
            }
        }
        private string movie_Genre;//create private string for Genre of the movie    /*1.Drama 2.Adventure    3.Family 4. Acrion 5. Sci-Fi 6. Comedy 7. Animated 8. Thriller*/
        public string Movie_GENRE  // getter and setter for Genre of that Movie
        {

            get
            {// get return the Genre of movie 
                return movie_Genre;
            }
            set
            {//then we set the Genre of the movie to be a value
                movie_Genre = value;
            }
        }
        private string movie_Classification;//create private string for Classification of the movie
        public string Movie_CLASSIFICATION  // getter and setter for Classification of that Movie
        {
            get
            {// get return the Classification of movie 
                return movie_Classification;
            }

            set
            {//then we set the Classification of the movie to be a value
                movie_Classification = value;
            }
        }
        private int movie_Duration;//create private string for Duration of the movie
        public int Movie_DURATION  // getter and setter for Duration of that Movie
        {
            get
            {// get return the Duration of movie 
                return movie_Duration;
            }
            set
            {//then we set the Duration of the movie to be a value
                movie_Duration = value;
            }
        }
        private int movie_ReleaseDate;//create private string for Rekease Year of the movie
        public int Movie_RELEASEDATE  // getter and setter for Rekease Year of that Movie
        {
            get
            {// get return the Rekease Year of movie 
                return movie_ReleaseDate;
            }

            set
            {//then we set the Rekease Year of the movie to be a value
                movie_ReleaseDate = value;
            }

        }
        private int movie_Availability;//create private string for avaialbility of the movie
        public int Movie_AVAILABILITY  // getter and setter for avaialbility of that Movie
        {
            get
            {// get return the avaialbility of movie 
                return movie_Availability;
            }

            set
            {//then we set the avaialbility of the movie to be a value
                movie_Availability = value;
            }
        }
        private int movie_Times_rented;//create private int for how many this movie rented
        public int MOVIE_TIMERENTED    // getter and setter for how many this movie rented
        {
            get
            {// get return the how many this movie rented 
                return movie_Times_rented;
            }
            set
            {//then we set the how many this movie rented to be a value
                movie_Times_rented = value;
            }
        }

        //  // create method to assign the information that we have added before to our parameters to show it to the 
        public Movie(string TITLE_OF_MOVIE, string STARRING_OF_MOVIE, string DIRECTORS_OF_MOVIE, string GENRE_OF_MOVIE
            , string CLASSIFICATION_OF_MOVIE, int DURATION_OF_MOVIE, int RELEASE_YEAR, int AVAILABILITY_OF_MOVIE, int RENTED_TIME_FOR_MOVIE)
        {
            //one of private string (int) = one of parameters:
          /*The movie TITLE */         Movie_TITLE = TITLE_OF_MOVIE;                    //is equal to the parameter of TITLE_OF_MOVIE
          /*The movie STARRING*/       Movie_STARRING = STARRING_OF_MOVIE;              //is equal to the parameter of STARRING_OF_MOVIE
          /*The movie DIRECTOR*/       Movie_DIRECTOR = DIRECTORS_OF_MOVIE;             //is equal to the parameter of DIRECTORS_OF_MOVIE
          /*The movie GENRE*/          Movie_GENRE = GENRE_OF_MOVIE;                    //is equal to the parameter of GENRE_OF_MOVIE
          /*The movie CLASSIFICATION*/ Movie_CLASSIFICATION = CLASSIFICATION_OF_MOVIE;  //is equal to the parameter of CLASSIFICATION_OF_MOVIE
          /*The movie DURATION*/       Movie_DURATION = DURATION_OF_MOVIE;              //is equal to the parameter of DURATION_OF_MOVIE
          /*The movie RELEASE DATE*/   Movie_RELEASEDATE = RELEASE_YEAR;                //is equal to the parameter of RELEASE_YEAR
          /*The movie AVALIABILITY*/   Movie_AVAILABILITY = AVAILABILITY_OF_MOVIE;      //is equal to the parameter of AVAILABILITY_OF_MOVIE
          /*The movie TIMERENTED*/     MOVIE_TIMERENTED = RENTED_TIME_FOR_MOVIE;        //is equal to the parameter of RENTED_TIME_FOR_MOVIE
        }
        public override string ToString()//this is how we gonna get the information of above inside the display the top10 popular movies
        {
            return 
                // the formula here is using the text for each of movie details we have then we add the private string(int) something that
                // we have added the getter and setter .
                 "\n________________________________________________\n"+
                 "| The Title of Movie is : " + Movie_TITLE + "\n" +   // this is for the title of the movie
                 "| The Starring Of Movie are : " + Movie_STARRING + "\n"+ // this is for the starring of the movie
                 "| The Director of the Movie: "+ Movie_DIRECTOR + "\n"+ // this is for Director of the movie
                 "| genre of the Movie: "+ Movie_GENRE + "\n"+ // this is for Genre of movie and we know that it has 8 things to select (Comedy, adventure ....etc)
                 "| classification of the Movie: "+ Movie_CLASSIFICATION + "\n"+ // this one has the classification of the movie and this contains of 4 things (genreal (G) ...etc)
                 "| The Duration of the Movie : " + Movie_DURATION.ToString() + "\n" + //this is to show what is the duration of the movie by minutes
                 "| The Release Date of the Movie: " + Movie_RELEASEDATE.ToString() + "\n" + // the release date of the movie by years (4 digits from 1888 to 2020)
                 "| The Number of Availablity of the Movie : " + Movie_AVAILABILITY.ToString() + "\n" +// this one for the availability of the film in our software 
                 "| How many Times the member Rented : " + MOVIE_TIMERENTED.ToString() + "\n"+ // how many times that this movie rented
                 "__________________________________________________\n";

            //Important NOTE : we have added the .ToString for (Movie_DURATION, Movie_RELEASEDATE, Movie_AVAILABILITY and MOVIE_TIMERENTED) because they are integers
        }
        public void MOVIE_IS_Borrowed() // when the movie has been borrowed:
        {
            movie_Availability = movie_Availability + 1; // in this time the copies of availability will be increased by the time it borrowed
        }
        //THIS IS important method to determine what will happen for MOVIE_TIMERENTED and movie_Availability after we make the borrow things
        public void MAKE_Renting_Time() // this is created because our time rented is set to be 0 so we need to make it increasing while the member borrow A movie
        {
            MOVIE_TIMERENTED = MOVIE_TIMERENTED + 1; // if the movie rented that means it will increased by the time it rented
            movie_Availability = movie_Availability - 1; // if the movie rented that means the copies of availability will decreased by the time rented increased
        }
    
        
       
    }
}
