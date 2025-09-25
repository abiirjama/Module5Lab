using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// namespace holds one or more classes
namespace Module5Lab
{
    internal class Player
    {
        //variables for the class attributes
        private string name;
        private int score;
        private int livesleft;
        //three constructors
        //first constructor creates a player object
        //without setting the values of attributes
        public Player()
        {

        }//end constructor 
         //second  constructor 

        public Player(string name)
        {
            //set the value of the attribute on the player object
            //to the name value that was passed when the method was called 
            this.name = name;

        }//end constructor
         // third constructor 
        public Player(string name, int startinglives)
        {
            //set the name attribute and the livesleft attribute 
            //to the values that were passed to the constructor
            //method 
            this.name = name;
            livesleft = startinglives;

        }//end constructor 
         // methods - these are tasks or actions that our object
         //can preform or that can change the state of the object
         //this method returns the score
        public int getscore()
        {
            return score;

        }// end method 
         //this method increments the points the player has
        public void addpoints(int totalpoints)
        {
            // increment the score
            score += totalpoints;
            //score=score+totalpoints

        }//end method 
         //thsi method kills off  the  player 
        public void kill()
        {
            //we make sure they cant  get negative lives
            if (livesleft > 0)
            {
                livesleft--;
                // livesLeft = livesLeft - 1;
            } //end if
        } //end method
        public int GetLivesLeft()
        {
            return livesleft;
        } //end method
    }//end class
}//end namespace

