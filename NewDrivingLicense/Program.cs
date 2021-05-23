/***************************************************************************************
 * Very Hard Level of Difficulty
 * 
 * You have to get a new driver's license. You show up at the office at the same time as 
 * four other people. The office says they will see everyone in alphabetical order and it 
 * takes 20 minutes for them to process each new license. All of the agents are available 
 * now, and they can each see one customer at a time. How long will it take for you to 
 * walk out with your new license?
 * 
 * Your input will be a string of your name, an integer of the number of available agents, 
 * and a string of the other four names separated by spaces others.
 * 
 * Return the number of minutes it will take to get your license.
 * 
 * Examples
 * License("Eric", 2, "Adam Caroline Rebecca Frank") ➞ 40
 * // As you are in the second group of people.
 * 
 * License("Zebediah", 1, "Bob Jim Becky Pat") ➞ 100
 * // As you are the last person.
 * 
 * License("Aaron", 3, "Jane Max Olivia Sam") ➞ 20
 * // As you are the first.
 * 
 * Approach:
 * compare - check you placement
 * check the num of agents, if your position is slow than/greater than the number of agent
 * then you have to wait 20 mins for every person before you
*******************************************************************************************/
using System;

namespace NewDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = License("Eric", 2, "Adam Caroline Rebecca Frank");
            //int time = License("Zebediah", 1, "Bob Jim Becky Pat");
            //int time = License("Aaron", 3, "Jane Max Olivia Sam");
            Console.WriteLine(time);
        }
        
        static public int License(string name, int numOfAgents, string namesOfOthersWaiting)
        {
            int time = 20;  //it takes 20 min even if you're first
            string[] allNames = namesOfOthersWaiting.Split(' ');
            string firstLetter = name.Substring(0, allNames.Length-1); //"E"
            int positionInLine = 1;
            for (int i=0; i < allNames.Length; i++)
            {
                namesOfOthersWaiting = allNames[i]; //Adam                
                string firstLetterOfOthersName = allNames[i].Substring(0, allNames.Length - 1); //"A"
                                                                              
                //Comnpare first letter of names, if you're first letter comes after
                if (firstLetter.CompareTo(firstLetterOfOthersName) > 0) //0 if equal, -1 if a < b, 1 if a > b
                {                   
                    //Console.WriteLine(firstLetter + " is after " + firstLetterOfOthersName);   //returns -1
                    positionInLine += 1;
                    //Console.WriteLine("Num of agents: " + numOfAgents + "\nPosition in line: " + positionInLine);
                    if (numOfAgents < positionInLine) //if there isn't enough agent
                    {                       
                        //Console.WriteLine("got here - there isn't enough agents");
                        time += 20;
                        //Console.WriteLine("Time: " + time);
                    }
                }                        
            }
            //Console.WriteLine("Position in line: " + positionInLine);

            return time;
        }
    }
}