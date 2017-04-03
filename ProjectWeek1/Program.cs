using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome user to the fortune-telling site.
            //Put lines of text in strings.
            string welcomeText = "Welcome, honored guest.";
            string welcomeText2 = "If you have entered our domain, you must desire the divination of your future.";
            string welcomeText3 = "You may think you are entering your information into a mere computer.";
            string welcomeText4 = "However, your answers wing directly to the arms of fate.";
            string welcomeText5 = "The mists of the future both entice and tempt.";
            string welcomeText6 = "If at any time, your feet begin to falter, simply enter \"quit.\"";
            string welcomeText7 = "Proceed if you dare!";
            
            //Print lines of text, center.
            Console.SetCursorPosition((Console.WindowWidth - welcomeText.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeText);
            Console.SetCursorPosition((Console.WindowWidth - welcomeText2.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeText2);
            Console.SetCursorPosition((Console.WindowWidth - welcomeText3.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeText3);
            Console.SetCursorPosition((Console.WindowWidth - welcomeText4.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeText4);
            Console.SetCursorPosition((Console.WindowWidth - welcomeText5.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeText5);
            Console.SetCursorPosition((Console.WindowWidth - welcomeText6.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeText6);
            Console.SetCursorPosition((Console.WindowWidth - welcomeText7.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeText7);

            //Get user input. Build in option to quit the program at every step.
            // Ask for user name.
            Console.Write("\r\n\r\nWhat is your first name? \t\t");
            string firstName = Console.ReadLine().Trim();
            if (firstName.ToLower() == "quit")
            {
                Console.WriteLine("\r\nNobody likes a quitter...");
                Environment.Exit(0);
            }
            else { }
            Console.Write("\r\nWhat is your last name? \t\t");
            string lastName = Console.ReadLine().Trim();
            if (lastName.ToLower() == "quit")
            {
                Console.WriteLine("\r\nNobody likes a quitter...");
                Environment.Exit(0);
            }
            else { }

            //Ask for user age.
            Console.Write("\r\nWhat is your age? \t\t\t");
            string userAge = Console.ReadLine().Trim();
            //Test to see if userAge is a number and filter it from a string to an int.
            double userAgeNum;
            if (userAge.ToLower() == "quit")
            {
                Console.WriteLine("\r\nNobody likes a quitter...");
                Environment.Exit(0);
            }
            else if (!double.TryParse(userAge, out userAgeNum))
            {
                Console.WriteLine("Uh-oh, invalid entry. Your punishment shall be... you'll see!");
            }
            else if (double.TryParse(userAge, out userAgeNum) && userAgeNum < -1)
            {
                Console.WriteLine("Uh-oh, invalid entry. Your punishment shall be... you'll see!");
            }
            else { }

            //Ask for user birth month.
            Console.Write("\r\nWhat is your birth month? (in 00 form)  ");
            string birthMonth = Console.ReadLine().Trim();
            //Test to see if birthMonth is a number and filter it from a string to an int
            double birthMonthNum;
            if (birthMonth.ToLower() == "quit")
            {
                Console.WriteLine("\r\nNobody likes a quitter...");
                Environment.Exit(0);
            }
            else if (!double.TryParse(birthMonth, out birthMonthNum))
            {
                Console.WriteLine("Trying to trick me by entering invalid information? You'll regret it!");
            }
            else if (double.TryParse(birthMonth, out birthMonthNum) && birthMonthNum > 12 || birthMonthNum < 0)
            {
                Console.WriteLine("Trying to trick me by entering invalid information? You'll regret it!");
            }
            else { }


            // Before prompt for favorit ROYGBIV color, prompt user to ask for help (ie a list of the colors).
            Console.Write("\r\n(We will need to know your favorite ROYGBIV color. If you don't know what ROYGBIV colors are, please enter \"help.\") \t");
            string favColor = Console.ReadLine().Trim().ToLower();
            if (favColor == "help")
            {
                Console.WriteLine("\t- Red \r\n\t- Orange \r\n\t- Yellow \r\n\t- Green \r\n\t- Blue \r\n\t- Indigo \r\n\t- Violet");
                Console.Write("What is your favorite ROYGBIV color? \t");
                favColor = Console.ReadLine();
                if (favColor == "quit")
                {
                    Console.WriteLine("\r\nNobody likes a quitter...");
                    Environment.Exit(0);
                }
                else { }
            }
            else if (favColor == "quit")
            {
                Console.WriteLine("\r\nNobody likes a quitter...");
                Environment.Exit(0);
            }
            else
            {
            }

            //Ask for user number of siblings.
            Console.Write("\r\nHow many siblings do you have? \t\t");
            string userSibling = Console.ReadLine();
            //Test to see if user input is a number and filter input to become an int.
            double siblingNum;
            if (userSibling.ToLower() == "quit")
            {
                Console.WriteLine("\r\nNobody likes a quitter...");
                Environment.Exit(0);
            }
            else if (!double.TryParse(userSibling, out siblingNum))
            {
                Console.WriteLine("Now, you and I both know you can't have \"" + userSibling + "\" number of siblings... Your fortune shall reflect your falseness!");
            }
            else if (double.TryParse(userSibling, out siblingNum) && siblingNum < 0)
            {
                Console.WriteLine("Now, you and I both know you can't have \"" + userSibling + "\" number of siblings... Your fortune shall reflect your falseness!");
            }
            else { }

            //Allow exit option at end of user input form
            Console.Write("\r\nDo you feel anticipation rising within you? \r\n\r\nIf you desire to proceed, press enter. \r\nIf you feel a growing unease, please heed the warnings of your heart. Enter \"quit\" now! \t");
            string exitPreRePrint = Console.ReadLine().ToLower();
            if (exitPreRePrint == "quit")
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\r\nAh! You are truly faint of heart. \r\nDo not expect much for your future. Nobody likes a quitter...");
                Environment.Exit(0);
            }
            else { }

            //Clear user form in order to re-print user info
            Console.ReadKey();
            Console.Clear();

            //switch birth month (number) to the name of the month to use when reprinting user input back to user.
            string birthMonthName;
            switch (birthMonth.Trim())
            {
                case "1":
                case "01":
                    birthMonthName = "(January)";
                    break;
                case "2":
                case "02":
                    birthMonthName = "(Febraury)";
                    break;
                case "3":
                case "03":
                    birthMonthName = "(March)";
                    break;
                case "4":
                case "04":
                    birthMonthName = "(April)";
                    break;
                case "5":
                case "05":
                    birthMonthName = "(May)";
                    break;
                case "6":
                case "06":
                    birthMonthName = "(June)";
                    break;
                case "7":
                case "07":
                    birthMonthName = "(July)";
                    break;
                case "8":
                case "08":
                    birthMonthName = "(August)";
                    break;
                case "9":
                case "09":
                    birthMonthName = "(September)";
                    break;
                case "10":
                    birthMonthName = "(October)";
                    break;
                case "11":
                    birthMonthName = "(November)";
                        break;
                case "12":
                    birthMonthName = "(December)";
                    break;
                default:
                    birthMonthName = "";
                    break;
            }

            //Reprint user information
            Console.WriteLine("Before we continue, it is important to ensure that you have answered our questions properly. After all, who knows how hearing the wrong fortune may alter your future!");
            Console.WriteLine("\r\n\r\n\tYour name is " + firstName + " " + lastName + ".");
            Console.WriteLine("\tYou are " + userAge + " years old.");
            Console.WriteLine("\tYour birth month is " + birthMonth + " "+birthMonthName + ".");
            Console.WriteLine("\tYour favorite color is " + favColor + ".");
            Console.WriteLine("\tYou have " + userSibling + " sibling(s).");
            Console.WriteLine("\r\nIf you have provided false information, please consider turning back now! \r\n\r\nIf you would like to proceed into the mist, please press enter.");
            //Provide exit option
            Console.Write("If you quail in the face of that which is to come, you may choose to enter \"quit.\" \t");
            string exitPreFortune = Console.ReadLine().ToLower();
            if (exitPreFortune == "quit")
            {
                Console.WriteLine("\r\nCome now. Truly, nobody likes a quitter...");
                Environment.Exit(0);
            }
            else { }

            //Clear page before printing fortune
            Console.ReadKey();
            Console.Clear();


            // Declare the variables that will store the output for the user's fortune in the conditional statements.
            string retirementText;
            double moneyInBank;
            string vacationHome;
            string modeTransport;

            //Filter information from user input through conditional statements to get fortune results.
            //User Age translated into years until retirement.
            if (!double.TryParse(userAge, out userAgeNum))
            {
                retirementText = "200 years (better hope for immortality!)";
            }
            else if (userAgeNum % 2 == 0)
            {
                retirementText = "20 years";
            }
            else
            {
                retirementText = "5 years";
            }

            //Number of Siblings coverted to vacation home location
            if (!double.TryParse(userSibling, out siblingNum))
            {
                vacationHome = "a tent in Antarctica";
            }
            else if (siblingNum == 0)
            {
                vacationHome = "a Quechuan-style cottage high in the Andes";
            }
            else if (siblingNum > 0 && siblingNum <= 1)
            {
                vacationHome = "a houseboat on the French Riviera";
            }
            else if (siblingNum > 1 && siblingNum <= 2)
            {
                vacationHome = "a Tibetan Monestary";
            }
            else if (siblingNum > 2 && siblingNum <= 3)
            {
                vacationHome = "an igloo in Nunavut, Canada";
            }
            else if (siblingNum > 3)
            {
                vacationHome = "a penthouse in NYC";
            }
            else
            {
                vacationHome = "a trunk shipped to Timbuktu";
            }

            //Favorite color determines mode of transport.
            switch (favColor)
            {
                case "red":
                    modeTransport = "1962 250 GT Lusso Berlinetta";
                    break;
                case "orange":
                    modeTransport = "Jetta";
                    break;
                case "yellow":
                    modeTransport = "custom diesel rocketship (the aerial companion to the Yellow Submarine)";
                    break;
                case "green":
                    modeTransport = "llama (if he talks, beware! You may have found an emperor...)";
                    break;
                case "blue":
                    modeTransport = "Nightfury (do you even have to park a dragon? I hope not!)";
                    break;
                case "indigo":
                    modeTransport = "1960's motorhome";
                    break;
                case "violet":
                    modeTransport = "flying carpet (it's a whole new world!)";
                    break;
                default:
                    modeTransport = "dog sled (time to get creative!)";
                    break;
            }

            //birth month number determines the amount of money in the bank.
            if (!double.TryParse(birthMonth, out birthMonthNum))
            {
                moneyInBank = 0d;
            }
            else if (birthMonthNum >= 1 && birthMonthNum <= 4)
            {
                moneyInBank = 1.40d;
            }
            else if (birthMonthNum >= 5 && birthMonthNum <= 8)
            {
                moneyInBank = 1000000000d;
            }
            else if (birthMonthNum >= 9 && birthMonthNum <= 12)
            {
                moneyInBank = 50000d;
            }
            else
            {
                moneyInBank = 0.00d;
            }

            //Print user's fortune, text center
            //Put lines of text into strings.
            string fortuneIntro = "Do you feel the mists at work? Read and revel in your glorious future!\r\n\r\n";
            string fortuneLine1 = firstName + " " + lastName + " will retire in " + retirementText;
            string fortuneLine2 = "with " + moneyInBank.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us")) + " in the bank,";
            string fortuneLine3 = "a vacation home in " + vacationHome;
            string fortuneLine4 = "and a " + modeTransport + ".\r\n\r\n";
            string fortuneConc = "May the force be with you.";

            //Print lines of text, center.
            Console.SetCursorPosition((Console.WindowWidth - fortuneIntro.Length) / 2, Console.CursorTop);
            Console.WriteLine(fortuneIntro);
            Console.SetCursorPosition((Console.WindowWidth - fortuneLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(fortuneLine1);
            Console.SetCursorPosition((Console.WindowWidth - fortuneLine2.Length) / 2, Console.CursorTop);
            Console.WriteLine(fortuneLine2);
            Console.SetCursorPosition((Console.WindowWidth - fortuneLine3.Length) / 2, Console.CursorTop);
            Console.WriteLine(fortuneLine3);
            Console.SetCursorPosition((Console.WindowWidth - fortuneLine4.Length) / 2, Console.CursorTop);
            Console.WriteLine(fortuneLine4);
            Console.SetCursorPosition((Console.WindowWidth - fortuneConc.Length) / 2, Console.CursorTop);
            Console.WriteLine(fortuneConc);

        }


        }
    }
