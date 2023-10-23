using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace student_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            static string LikeToKnow()
            {
                return ("What would you like to know? Enter 'hometown' or 'favorite food' ");
            }

           static string answeredWrong()
            {
                return ("This is not a category");
            }
            
            

            string[] studentNames = new string[4] { "Aimee ", "Angela ", "Frank ", "Nate " };

            string[] studentTowns = new string[4] { "Detroit ", "Redford ", "Lansing ", "Ann Arbor " };

            string[] studentFav = new string[4] { "Sushi ", "Italian ", "Mexican ", "Mediterranean " };

    


            string MoreInfo = "y";
            while (MoreInfo == "y" || MoreInfo == "Y")
            {
                Console.WriteLine("Which student would you like to learn more about? Enter a number 1-4");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput < 1 || userInput > 4)
                {
                    Console.WriteLine("Invalid number!");
                }

                else if (userInput == 1)
                {
                    string name = studentNames[0];
                    Console.WriteLine(name);
                    Console.WriteLine(LikeToKnow());
                    string answer = Console.ReadLine();

                    while (answer == "hometown " || answer == "favorite food");
                    {
                        if (string.Equals(answer, "hometown", StringComparison.CurrentCultureIgnoreCase))
                        {
                            string townAtIndexz = studentTowns[0];
                            Console.WriteLine(townAtIndexz);

                        }
                        else if (string.Equals(answer, "favorite food", StringComparison.CurrentCultureIgnoreCase))
                        {
                            string foodAtIndexz = studentFav[0];
                            Console.WriteLine(foodAtIndexz);
                        }
                    }
                    Console.WriteLine(answeredWrong());

                }
                else if (userInput == 2)
                {
                    string name1 = studentNames[1];
                    Console.WriteLine(name1);
                    Console.WriteLine(LikeToKnow());
                    string answer2 = Console.ReadLine();

                    while (answer2 == "hometown " || answer2 == "favorite food") ;
                    {
                        if (string.Equals(answer2, "hometown", StringComparison.CurrentCultureIgnoreCase))
                        {
                            string townAtIndex1 = studentTowns[1];
                            Console.WriteLine(townAtIndex1);
                        }
                        else if (string.Equals(answer2, "favorite food", StringComparison.CurrentCultureIgnoreCase))
                        {
                            string foodAtIndex1 = studentFav[1];
                            Console.WriteLine(foodAtIndex1);
                        }
                    }
                    Console.WriteLine(answeredWrong());
                }
                else if (userInput == 3)
                {
                    string name2 = studentNames[2];
                    Console.WriteLine(name2);
                    Console.WriteLine(LikeToKnow());
                    string answer3 = Console.ReadLine();

                    while (answer3 == "hometown" || answer3 == "favorite food")
                    {
                        if (string.Equals(answer3, "hometown", StringComparison.CurrentCultureIgnoreCase))
                        {
                            string townAtIndex2 = studentTowns[2];
                            Console.WriteLine(townAtIndex2);

                        }
                        else if (string.Equals(answer3, "favorite food", StringComparison.CurrentCultureIgnoreCase))
                        {
                            string foodAtIndex2 = studentFav[2];
                            Console.WriteLine(foodAtIndex2);

                        }
                    }
                    Console.WriteLine(answeredWrong());


                }
                else if (userInput == 4)
                {
                    string name3 = studentNames[3];
                    Console.WriteLine(name3);
                    Console.WriteLine(LikeToKnow());
                    string answer4 = Console.ReadLine();

                    while (answer4 == "hometown" || answer4 == "favorite food")
                    {
                        if (string.Equals(answer4, "hometown", StringComparison.CurrentCultureIgnoreCase))
                        {
                            string townAtIndex3 = studentTowns[3];
                            Console.WriteLine(townAtIndex3);
                        }
                        else if (string.Equals(answer4, "favorite food", StringComparison.CurrentCultureIgnoreCase))
                        {
                            string foodAtIndex3 = studentFav[3];
                            Console.WriteLine(foodAtIndex3);
                        }
                    }
                    Console.WriteLine(answeredWrong());


                }
                Console.WriteLine("Would you like to learn about another student (y/n)?");
                MoreInfo = Console.ReadLine();
            }    
            
            Console.WriteLine("Thank you for asking about our students!");
        }
            
        }
    }
    

