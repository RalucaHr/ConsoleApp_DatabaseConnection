using System;

namespace PrivateSchoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("TYPE 1 , 2, or 3");
                Console.WriteLine("1 to Input data ");
                Console.WriteLine("2 to Output database tables ");
                Console.WriteLine("3 to Exit app ");
                Console.WriteLine("----------------------------");
                int decision;

                Console.Write("Please type : ");
                decision = Convert.ToInt32(Console.ReadLine());

                if (decision == 1)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("TYPE NUMBER TO SELECT TABLE");
                            Console.WriteLine("1 Students ");
                            Console.WriteLine("2 Trainers ");
                            Console.WriteLine("3 Assignments ");
                            Console.WriteLine("4 Courses ");
                            Console.WriteLine("5 Students per course ");
                            Console.WriteLine("6 Trainers per course ");
                            Console.WriteLine("7 Assignments per student per course ");
                            Console.WriteLine("8 Go Back ");
                            Console.WriteLine("----------------------------");
                            int decision2;

                            Console.Write("Please type number: ");
                            decision2 = Convert.ToInt32(Console.ReadLine());

                            if (decision2 == 1)
                            {
                                InsertInputData.InsertStudent();
                            }
                            else if (decision2 == 2)
                            {
                                InsertInputData.InsertTrainer();
                            }
                            else if (decision2 == 3)
                            {
                                InsertInputData.InsertAssignment();
                            }
                            else if (decision2 == 4)
                            {
                                InsertInputData.InsertCourse();
                            }
                            else if (decision2 == 5)
                            {
                                InsertInputData.InsertStudentsPerCourse();
                            }
                            else if (decision2 == 6)
                            {
                                InsertInputData.InsertTrainersPerCourse();
                            }
                            else if (decision2 == 7)
                            {
                                InsertInputData.InsertAssignmentPerStudentsPerCourse();
                            }
                            else if (decision2 == 8)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Wrong input! Please try again..\n");
                            }
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Please try again..\n");
                        }
                    }
                }
                else if (decision == 2)
                {
                    PrintDatabase.Output();
                }
                else if (decision == 3)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong input! Please try again..\n");
                }
            }
        }
    }
}
