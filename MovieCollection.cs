
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Yousif_Community_Library_Software_Application
{// class of Movie Collection
    public class MovieCollection

        /*
     the movie collection class should has some     
     
     */
    {
        // we need to create 2 private TreeNode 
        private TreeNode Renting_time_Of_the_Movie, get_add_Working;
        // make this int to be equal to 0
        private int What_number = 0;
        

        // create a method to grab movie and put it through this class:
        public bool Put_A_Movie(Movie Access_from_MovieCS)
        {
            //then we create an object to get access from the TreeNode Class
            TreeNode Access_from_TreeNode_CS = new TreeNode(Access_from_MovieCS);
            // if our get_add_Working is not being used correctly
            if (get_add_Working == null)
            {
                // the we  send it to our object to be get the access to the TreeNode Class
                get_add_Working = Access_from_TreeNode_CS;
                // if all that happens we will return true for that
                return true;
            }

            else // if the get_add_Working is used correctly in our class here:
            {
                // we create another TreeNode and this one gonna be equal to the
                //get_add_Working and also the Main_node_in_TreeNode
                TreeNode What_is_the_used_Node = get_add_Working, Main_node_in_TreeNode;

                // and if that is going to be correct:
                while (true)
                {// that means we can play around between the Movie collect and TreeNode classes to get the Movie working
                    // so our Main_node_in_TreeNode that we have created previoulsy is gonna equal to the other What_is_the_used_Node 
                    Main_node_in_TreeNode = What_is_the_used_Node;
                    //What_is_the_used_Node.TreeTreeDataStructureStructure.Movie_Movie_TITLE.CompareTo(Access_from_MovieCS.Movie_Movie_TITLE);

                    // if the TreeNode that we have created befire has access to the data structure Node in the TreeNode Class 
                    // and the data structure node has connected to the Title of he moviw is less than zero:
                    if (What_is_the_used_Node.TreeDataStructure.Movie_TITLE.CompareTo(Access_from_MovieCS.Movie_TITLE) < 0)
                    {// this means the TeeNode that we have created before is gonna go to the left node
                        What_is_the_used_Node = What_is_the_used_Node.TreeNodeLeft;
                        //and if the What_is_the_used_Node is used wrongly:
                        if (What_is_the_used_Node == null)
                        {// this means the Main_node_in_TreeNode of the left tree node is gonna be accessed to the TreeNode Class
                            Main_node_in_TreeNode.TreeNodeLeft = Access_from_TreeNode_CS;
                            // then return it to be true
                            return true;
                        }
                    }
                   // if the TreeNode that we have created before has access to the data structure Node in the TreeNode Class
                    // and the data structure node has connected to the Title of he moviw is greater than zero:
                    else if (What_is_the_used_Node.TreeDataStructure.Movie_TITLE.CompareTo(Access_from_MovieCS.Movie_TITLE) > 0)
                    {// then we make the What_is_the_used_Node is also has access to the left tree node
                        What_is_the_used_Node = What_is_the_used_Node.TreeNodeLeft;

                        // but also if the What_is_the_used_Node is wrongly used :
                        if (What_is_the_used_Node == null)
                        {// this means the left tree node of the Main_node_in_TreeNode is gonna b has access to the TreeNode Class
                            Main_node_in_TreeNode.TreeNodeLeft = Access_from_TreeNode_CS;
                            //Also return True
                            return true;
                        }
                    }
                    else // if all these note mentioned :
                    { // this means we need to return false and this means everything else gonna be wrong if it hasn't relates to the previous stepps 
                        return false;
                    }// end else
                }
            }

        }

        


         

        // create a method to delete the movie :
        public bool Make_The_Deletion_For_AMovie(string Movie_TITLE_For_Our_Movie)
        {//create a TreeNode calls Removing_The_Specific_Movie which is used to delete the specific tree node
            TreeNode Removing_The_Specific_Movie = Make_Deletion_for_ATreeNode(get_add_Working, Movie_TITLE_For_Our_Movie);
            // and if this thing that we have created is not related to the get_add_Working
            if (Removing_The_Specific_Movie != get_add_Working)
            {// this means our work is not correct and we return False for that
                return false;
            }
            //and this ginna equall to the TreeNode that we have created previoulsy
            get_add_Working = Removing_The_Specific_Movie;
            //after that we return true and our work is going to be correct
            return true;
        }

        // create private method to determine what is the expected from the movie
        private Movie what_the_Movie_Expects(TreeNode get_add_Working)
        {
            // the parameter here is also related to te=he Main Node of the Tree node
            //if we say that the parameter of the left tree is nothing
            if (get_add_Working.TreeNodeLeft != null)
            {// then the parameter of the data structure is equal to the left tree node of the data sreucture
                get_add_Working.TreeDataStructure = get_add_Working.TreeNodeLeft.TreeDataStructure;
                // and then we say the parameter is the same of the parameter of the left tree
                get_add_Working = get_add_Working.TreeNodeLeft;
            }
            // after that we return the idea of the data structure of the main node
            return get_add_Working.TreeDataStructure;
        }


        // create a method to delete the node and this is done by saying that:
        TreeNode Make_Deletion_for_ATreeNode(TreeNode Removing_The_Specific_Movie, string Movie_TITLE_For_Our_Movie)
        {
            // if we haven't removed anything then:
            if (Removing_The_Specific_Movie == null)
                // we return the removed and saying that this is not deleted
                return Removing_The_Specific_Movie;
            
            // but if we deleted the data structure by connecting it with the title of the movie is less than zero:
            if (Removing_The_Specific_Movie.TreeDataStructure.Movie_TITLE.CompareTo(Movie_TITLE_For_Our_Movie) < 0)
            {// then we return the left tree node to be deleted  because it is smaller than the other tree nodes
                Removing_The_Specific_Movie.TreeNodeLeft = Make_Deletion_for_ATreeNode(Removing_The_Specific_Movie.TreeNodeLeft, Movie_TITLE_For_Our_Movie);
            }
            // butif we deleted the data structure by connecting it with the title of the movie is smore  than zero:
            else if (Removing_The_Specific_Movie.TreeDataStructure.Movie_TITLE.CompareTo(Movie_TITLE_For_Our_Movie) > 0)
            {// then we return the right tree node to be deleted  because it is  bigger  than the other left tree nodes
                Removing_The_Specific_Movie.TreeNodeRight = Make_Deletion_for_ATreeNode(Removing_The_Specific_Movie.TreeNodeRight, Movie_TITLE_For_Our_Movie);
            }
            else// if those haven't been happened then:
            {
                // and that means if the left node is nothing:
                if (Removing_The_Specific_Movie.TreeNodeLeft == null)
                {// then we return the right node
                    return Removing_The_Specific_Movie.TreeNodeRight;
                }
                //but of the tight node is nothing :
                else if (Removing_The_Specific_Movie.TreeNodeRight == null)
                {
                    //then we return the left tree 
                    return Removing_The_Specific_Movie.TreeNodeLeft;
                }
                // these all means that if we want to remove the data structure, this means we expect to delete the left node
                Removing_The_Specific_Movie.TreeDataStructure = what_the_Movie_Expects(Removing_The_Specific_Movie.TreeNodeLeft);
                // and if the left node has removed ,  then we remove the speific left node and also the data structure of the title of the movie
                Removing_The_Specific_Movie.TreeNodeLeft = Make_Deletion_for_ATreeNode(Removing_The_Specific_Movie.TreeNodeLeft,
                    Removing_The_Specific_Movie.TreeDataStructure.Movie_TITLE);

            }// after that we return the specific deletion for the movie 
            return Removing_The_Specific_Movie;
        }// end method  TreeNode Make_Deletion_for_ATreeNode


        
       

      
       



        // create the boolean method to borrow the movie :
        private bool Make_the_Borrow(TreeNode Removing_The_Specific_Movie, string Movie_TITLE_For_Our_Movie)
        {// we say if the removed movies are not available:
            while (Removing_The_Specific_Movie != null)
            {
                // so we have 3 possible point is that is happened
                //1. while not the removing the title of data structure is less tham 0 and also not the 
               // not the removing the title of data structure is more tham 0, then:
                if (!(Removing_The_Specific_Movie.TreeDataStructure.Movie_TITLE.CompareTo(Movie_TITLE_For_Our_Movie) < 0) &&
                    (Removing_The_Specific_Movie.TreeDataStructure.Movie_TITLE.CompareTo(Movie_TITLE_For_Our_Movie) > 0))
                {
                    // we say that to return true while the data structure of the avaialble movies is more than Zero 
                    while (Removing_The_Specific_Movie.TreeDataStructure.Movie_AVAILABILITY > 0)
                    {// we said it returns true because we went to the Movie class and we have taken the time rented for the data structure
                        Removing_The_Specific_Movie.TreeDataStructure.MAKE_Renting_Time();
                        // this is why we return ture
                        return true;
                    }
                }
                //but while also the data structure of the title of the movie is greater than zero:
                else if (Removing_The_Specific_Movie.TreeDataStructure.Movie_TITLE.CompareTo(Movie_TITLE_For_Our_Movie) > 0)
                {// we say to make removing for the right tree of the node
                    Removing_The_Specific_Movie = Removing_The_Specific_Movie.TreeNodeRight;
                }
                //but while also the data structure of the title of the movie is less than zero:
                else if (Removing_The_Specific_Movie.TreeDataStructure.Movie_TITLE.CompareTo(Movie_TITLE_For_Our_Movie) < 0)
                {// we say to make removing for the left tree of the node
                    Removing_The_Specific_Movie = Removing_The_Specific_Movie.TreeNodeLeft;
                }
                
            }
            return false;
        }
        // this method to be accessed to the Main Method that we use it to make the return if we press on 2
        // and without the previous public for the Borrow, this method is gonna be unuseful
        public bool Make_the_Borrow(string Movie_TITLE_For_Our_Movie)
        {// so we return the borrow of the title and 
            return Make_the_Borrow(get_add_Working, Movie_TITLE_For_Our_Movie);
        }



      

       // this method is used to get what is the exact number of the node
        private int Get_the_Exact_Number(TreeNode From_Our_Node)
        {// while our paramwter is null 
             if (From_Our_Node == null)
            {// return 0 and that means return false 
                return 0;
            }
             else{
                // otherwise while it is not null :
                //return the exact number of  letf tree plus adding one to get the right node 
                return (Get_the_Exact_Number(From_Our_Node.TreeNodeLeft) + 1 + Get_the_Exact_Number(From_Our_Node.TreeNodeRight));
            }
        }
        // this public method will be used if the we want 
      //  public int Get_the_Exact_Number()
      //  {
      //      return Get_the_Exact_Number(get_add_Working);
      //  }

            // create the method to display the top in A Z order:
        private void A_Z_Display(TreeNode Removing_The_Specific_Movie)
        {// and while the the removing is not available : 
            if (Removing_The_Specific_Movie != null)
            { // then we can get the az order starts from the right tree and then
                A_Z_Display(Removing_The_Specific_Movie.TreeNodeRight);
                // also we need to print out the data structure of the removed Movie and convert it because 
                // data structure is interger value  and we need to convert it to string value
                string cinverting_the_TreeNodeStructure = Removing_The_Specific_Movie.TreeDataStructure.ToString() + "\n";
                // Also we print the thing using theConsole.WriteLine()
                Console.Write(cinverting_the_TreeNodeStructure);
                // then we can get the az order finished at the left tree of the node
                A_Z_Display(Removing_The_Specific_Movie.TreeNodeLeft);
            }
        }
        // this  method to show that AZ display has been enabled 
        //(so if we remove the A_Z methid, this method will be useless)
        // so we need to use this method in Menu class to display in AZ order
        public void ShowEverything()
        {//this will take the  main node and sort it by a z order
            A_Z_Display(get_add_Working);
        }

      //the method to display top 10 borrowd:
        public void DisplayT10()
        { // first of allwe say that what_number value is initialised by 0
            What_number = 0;
            // then while the renting time of our move is not avaialble,
            Renting_time_Of_the_Movie = null;
            // then we need to sort the time rented of the main node  (get_add_Working)
            Time_rent_sort(get_add_Working);
            // then we make the display 10 method to be availble depending on the time rented
            DisplayT10(Renting_time_Of_the_Movie);
        }

       // this method is going to be used if the Displayt10 method was worked correctly 
        private void Time_rent_sort(TreeNode Removing_The_Specific_Movie)
        {// because if the deleting of the movie is avaialble:
            if (Removing_The_Specific_Movie != null)
            {// we make the sorting for the time for the right node
                Time_rent_sort(Removing_The_Specific_Movie.TreeNodeRight);
                // then we say that the move renting is sorted with the data structure 
                Renting_time_Of_the_Movie = sorting_the_time_Rented_for_Movie(Renting_time_Of_the_Movie, Removing_The_Specific_Movie.TreeDataStructure);
                // and then make the removing for left tree node
                Time_rent_sort(Removing_The_Specific_Movie.TreeNodeLeft);
            }
           
        }

       

            // method to display the top 10 most popular Movies:
        private void DisplayT10(TreeNode Removing_The_Specific_Movie)
        {// we create a string confirmation_Of_Making_The_Display showing we display this movie that has been borrowed:
            string confirmation_Of_Making_The_Display = " has been successfully borrowed ";
            // creating the confirmation_Of_displaying_timesMSG so we add how many times this movie has been borrowed
            string confirmation_Of_displaying_timesMSG = " times.\n";

            // so if we think that  we haven't removed the movie :
            if (What_number < 10  && Removing_The_Specific_Movie != null)
            {// this meeans we will increase the What_number by 1.
                What_number = What_number + 1;
                // then we do the displaying top 10 process by removing the specific movie of the Right tree node
                DisplayT10(Removing_The_Specific_Movie.TreeNodeRight);
                // after that we print the result that we have done to show that the displaying process has been created correctly and
                // we show the things on the screen
                Console.WriteLine(Removing_The_Specific_Movie.TreeDataStructure.Movie_TITLE + confirmation_Of_Making_The_Display +
                    Removing_The_Specific_Movie.TreeDataStructure.MOVIE_TIMERENTED.ToString() + confirmation_Of_displaying_timesMSG);
                //then we display the process of the left tree
                DisplayT10(Removing_The_Specific_Movie.TreeNodeLeft);
                //Note: the reason of showing the right tree first : because we know that the  left tree < right tree and everytime the 
                // lower number comes lately and the higher nymber comes firstly
            }
        }

     

            // create private Method to have the time rented for movie to be sorted :
        private TreeNode sorting_the_time_Rented_for_Movie(TreeNode Removing_The_Specific_Movie, Movie From_the_Movie)
        {
            // if there is no removing for a movie (no movie created at all) 
            if (Removing_The_Specific_Movie == null)
            {
                // this means we gonna create new object from the parameter we have that gotton accessed from the Movie Class
                return  new TreeNode(From_the_Movie);
            }
            // if the parameter is relates to the time rent that we have created in Movie Class is less that the data structure of the time remted:
            if (From_the_Movie.MOVIE_TIMERENTED < Removing_The_Specific_Movie.TreeDataStructure.MOVIE_TIMERENTED)
            {// this means if the left node is deleted, this means it will be sorted by time rented
                Removing_The_Specific_Movie.TreeNodeLeft = sorting_the_time_Rented_for_Movie(Removing_The_Specific_Movie.TreeNodeLeft, From_the_Movie);
            }
            else // if the parameter is relates to the time rent that we have created in Movie Class is greatert han the data structure of the time remted:
            { // this means if the right node is deleted, this means it will be sorted by time rented from the right node as well.
                Removing_The_Specific_Movie.TreeNodeRight = sorting_the_time_Rented_for_Movie(Removing_The_Specific_Movie.TreeNodeRight, From_the_Movie);
            }
            // then we need to return our method for delteing the specific Movie
            return Removing_The_Specific_Movie;
        }

    }
}
