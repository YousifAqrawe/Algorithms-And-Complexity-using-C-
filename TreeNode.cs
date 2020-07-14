using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yousif_Community_Library_Software_Application
{// class tree node 
    class TreeNode 
        /*
     the class TreeNode has the details of Binary search tree which is contain of 
     leftNode, RightNode and the MainNode int middle and in here i have created 3 private TreeNode
     for each of left,right and Main Node :
     */
    {
        //create private TreeNode for left Node of TreeNode class:
        private TreeNode tree_node_left;

        public TreeNode TreeNodeLeft
        {
            get
            {// get return the left node of TreeNode  
                return tree_node_left;
            }

            set
            { // we set the leftnode of TreeNode to be a value
                tree_node_left = value;
            }
        }

        //create private TreeNode for Right Node of TreeNode class:
        private TreeNode tree_node_right;
        public TreeNode TreeNodeRight
        {
            get
            {// get return the left node of TreeNode  
                return tree_node_right;
            }

            set
            {// we set the right of TreeNode to be a value
                tree_node_right = value;
            }
        }
        private Movie tree_dara_structure;
        // private string v;
        //private TreeNode additionForMovies;

        //create private TreeNode for data structure of TreeNode class:
        public Movie TreeDataStructure

        {
            get
            {// get return the data structure of TreeNode  
                return tree_dara_structure;
            }

            set
            {// we set the Data structure of TreeNode to be a value
                tree_dara_structure = value;
            }


        }

        // creating a method that is saying we create a new film by mentioning the Movie Class as the parameter 
        public TreeNode(Movie Make_A_Film)
        {
            //this means our data structre is gonna be equal to oue parameter 
            TreeDataStructure = Make_A_Film;
            // and if the left and right be equal to each other, that means we need to stop because this is wrong will be.
            while (TreeNodeLeft == TreeNodeRight)
            {
                break;
            }
        }
        
    }
}
