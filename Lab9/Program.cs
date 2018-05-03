using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-20): ");

            //int[] studentNumber = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            string[] names = { "Mary", "Elizabeth", "Michael", "William", "Linda", "Liz", "David", "Canadaisacountrybutnovascotiaisnot", "Joseph", "Susan", "Margaret", "Charles", "Thomas", "Christopher", "Sarah", "Dorothy", "Karen", "Daniel", "Rober", "Jennifer" };

            string[] hometowns = { "Detroit, MI", "Chicago, IL", "Sterling Heights, MI", "Madison Heights, MI", "Ann Arbor, MI", "Warren, MI", "Centerline, MI", "Yisilanti, MI", "Grand Rapids, MI", "Long Beach, CA", "Lansing, MI", "Flint, MI", "Kalamazoo, MI", "Saginaw, MI", "Dearborn, MI", "Southfield, MI", "Battle Creek, MI", "Novi, MI", "Monroe, MI", "New York City, NY" };

            string[] foods = { "Pizza", "Fries", "Shawarma", "Fahsa", "Ice Cream", "Donut", "Spaghetti", "Pancakes", "Steak", "Philly Steak Sandwhich", "Fried Chicken", "Rice", "Curry", "Frog Legs", "Offals", "Sushi", "Cake", "Noodles", "Cheesecake", "Lasagne" };

            string[] colors = { "blue", "amber", "amethyst", "azure", "blue", "beige", "black", "bronze", "silver", "gold", "violet", "purple", "jade", "lavender", "lilac", "olive", "pink", "red", "white", "yellow" };

            List<string> students = new List<string>();
            students.AddRange(names);

            List<string> homes = new List<string>();
            homes.AddRange(hometowns);

            List<string> foodies = new List<string>();
            foodies.AddRange(foods);

            List<string> colours = new List<string>();
            colours.AddRange(colors);

            

            bool truth = true;
            while (truth)
            {

                try
                {
                    string studentNum = Console.ReadLine();

                    int SNum = int.Parse(studentNum);
                    //bool checkSN = int.TryParse(studentNum, out int SNum);
                    //We can do either ArrayList or List, depending on what peter says i'll change it later
                    //ArrayList blah = new ArrayList();

                    //List<int> studentNumba = new List<int>();
                    //studentNumba.AddRange(studentNumber);

                    

                    //for (int i = SNum; i < SNum+1; i++)
                    //{
                    //    Console.WriteLine(colours[i]);
                    //}


                    //ArrayList students = new ArrayList();
                    
                    Console.Write($"\nStudent {SNum} is {students[SNum - 1]}. What would you like to know about {students[SNum - 1]}? \n(Enter \"hometown\" or \"favorite food\" or \"favorite color\" or \"all\"(for all the info)): ");

                    bool data = true;
                    while (data)
                    {
                        string input = Console.ReadLine().ToLower();
                        if (input == "hometown")
                        {
                            Console.WriteLine($"\n{students[SNum - 1]} is from {homes[SNum - 1]}.\n");
                            data = false;
                        }
                        else if (input == "favorite food")
                        {
                            Console.WriteLine($"\n{students[SNum - 1]} loves all food but especially {foodies[SNum - 1]}.\n");
                            data = false;
                        }
                        else if (input == "favorite color")
                        {
                            Console.WriteLine($"\n{students[SNum - 1]} loves the color {colours[SNum - 1]}.\n");
                            data = false;
                        }
                        else if(input == "all")
                        {
                            Console.WriteLine($"\n{students[SNum - 1]} is from {homes[SNum - 1]}. Loves {foodies[SNum - 1]} and the color {colours[SNum - 1]}.");
                            data = false;
                        }
                        else
                        {
                            Console.WriteLine("\nThat data does not exist. Please try again. (Enter \"hometown\" or \"favorite food\" or \"favorite color\" or \"all\")");
                            continue;
                        }
                    }
                    bool check = true;
                    while (check)
                    {
                        Console.Write("Would you like to know more? (enter \"yes\" or \"no\") \nOr would you rather add another students info? (enter \"add\" for that option):  ");
                        string move = Console.ReadLine().ToLower();
                        Console.WriteLine();

                        string name = "";
                        string hometown = "";
                        string food = "";
                        string col = "";

                        if (move == "add")
                        {
                            bool test1 = true;
                            while (test1)
                            {
                                Console.WriteLine("\nFantastic! Tell us the students name below.");
                                name = Console.ReadLine();
                                bool a = int.TryParse(name, out int b);
                                if (name == " "|| a || Regex.IsMatch(name, @"\s"))
                                {
                                    Console.WriteLine("\nInvalid input, try again!");
                                    continue;
                                }
                                else
                                {
                                    students.Add(name);
                                    test1 = false;
                                }
                            }

                            bool test2 = true;
                            while (test2)
                            {
                                Console.WriteLine($"\nWhat is the hometown of {name}?");
                                hometown = Console.ReadLine();
                                bool a = int.TryParse(hometown, out int b);
                                if (hometown == " " || a || Regex.IsMatch(hometown, @"\s"))
                                {
                                    Console.WriteLine("\nInvalid input, try again!");
                                    continue;
                                }
                                else
                                {
                                    homes.Add(hometown);
                                    test2 = false;
                                }
                            }
                            bool test3 = true;
                            while (test3)
                            {
                                Console.WriteLine($"\nExcellent! What is {name}'s favorite food in the world?");
                                food = Console.ReadLine();
                                bool a = int.TryParse(food, out int b);
                                if (food == " " || a || Regex.IsMatch(food, @"\s"))
                                {
                                    Console.WriteLine("\nInvalid input, try again!");
                                    continue;
                                }
                                else
                                {
                                    foodies.Add(food);
                                    test3 = false;
                                }
                            }

                            bool test4 = true;
                            while (test4)
                            {
                                Console.WriteLine($"\nLast but not least, what is {name}'s favorite color? This is the last step to properly put {name} into our database.");
                                col = Console.ReadLine();
                                bool a = int.TryParse(col, out int b);
                                if (col == " " || a ||Regex.IsMatch(col, @"\s"))
                                {
                                    Console.WriteLine("\nInvalid input, try again!");
                                    continue;
                                }
                                else
                                {
                                    colours.Add(col);
                                    test4 = false;
                                }
                            }

                            truth = true;
                            check = false;
                            Console.WriteLine($"\nCongrats!! {name} has been added to our database. \nPlease enter the next students number you want to learn about (enter a number 1-{students.Count}).");
                        }
                        else if (move == "yes")
                        {
                            truth = true;
                            check = false;
                            Console.Write($"Which student would you like to learn about next? (enter a number 1-{SNum}): ");

                        }
                        else if (move == "no")
                        {
                            truth = false;
                            check = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid, try again!");
                            continue;
                        }
                    }

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number inputted is outside of the indicated range, Please try again");
                    continue;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Number inputted is outside of the indicated range, Please try again");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format is incorrect!, Please try again");
                }
            }
        }

        //SpaceCheckerMethod does not work, try to refactor later. failed first time
    }
}
