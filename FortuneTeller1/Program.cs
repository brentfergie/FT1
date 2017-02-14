using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller1
{
    class Program
    {
        static void Main(string[] args)
        
            //This program asks for user info and creates a fun fortune displayed on the console for the participant.

        {   //Variables in this section are for gathering user info
            Console.WriteLine("Please enter your first name: ");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string userLastName = Console.ReadLine(); 

            Console.WriteLine("Please enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of the month you were born : ");
            int birthMonth = int.Parse(Console.ReadLine());
             
            Console.WriteLine("Please enter your favorite ROYGBIV color.  If you require a list of colors type \"Help\"");
            
            string userColorInput = Console.ReadLine().ToLower();

            if (userColorInput == "help")
            {
                Console.WriteLine("Choose Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                Console.ReadLine().ToLower();
            }

            Console.WriteLine("Please enter the number of siblings you have: ");
            int numberSiblings = int.Parse(Console.ReadLine());

            //Variables for second section used to store calcualtions based on info from first section
            string retireYear; 
            string vacationHome;
            string modeOfTransport;
            string retirementMoney;
 
            if (userAge % 2 ==0) //User Age determination for retirement year
            {
                retireYear = "five";
            }
             else
            {
                retireYear = "eight";
            }


            if (numberSiblings == 1)  //User number of siblings detrmination
            {
                vacationHome = "Oregon";
            }
            else if (numberSiblings == 0)
            {
                vacationHome = "Florida";
            }
            else if (numberSiblings == 2)
            {
                vacationHome = "Mexico";
            }
            else if (numberSiblings >= 3)
            {
                vacationHome = "California";
            }
            else
            {
                vacationHome = "North Pole";
            }

            

            if (userColorInput == "red") //User color choice determination for mode of transportation
            {
                modeOfTransport = "car";
            }
            else if (userColorInput == "orange")
            {
                modeOfTransport = "boat";
            }
            else if (userColorInput == "yellow")
            {
                modeOfTransport = "plane";
            }
            else if (userColorInput == "green")
            {
                modeOfTransport = "motorcycle";
            }
            else if (userColorInput == "blue") 
            {
                modeOfTransport = "bicycle";
            }
            else if (userColorInput == "indigo")
            {
                modeOfTransport = "skateboard";
            }
            else 
            {
                modeOfTransport = "hoverboard";
            }


            if (birthMonth == 1 || birthMonth <= 4) //User birth month determination for retirement money amount
            {
                retirementMoney = "$50k";
            }
            else if (birthMonth == 5 || birthMonth <=8)
            {
                retirementMoney = "$100k";
            } 
            else if (birthMonth == 9 || birthMonth <= 12)
            {
                retirementMoney = "$200k";
            }
            else
            {
                retirementMoney = "$0";
            }

            //Last section to display user's "fortune" based on info gathered and calculated
            Console.WriteLine(userFirstName + " " + userLastName + " will retire in " + retireYear + " years with " + retirementMoney + " in the bank, a vacation home in " + vacationHome + " and a " + modeOfTransport + ".");

        }
    }
}
