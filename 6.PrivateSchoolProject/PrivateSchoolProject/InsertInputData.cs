using System;
using System.Linq;

namespace PrivateSchoolProject
{
    public static class InsertInputData
    {
        public static void InsertStudent()
        {
            using (var db = new PrivateSchoolContext())
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter student details");
                        Console.Write("First name: ");
                        string FirstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        string LastName = Console.ReadLine();
                        Console.Write("Date of birth in format yyyy-MM-dd : ");
                        DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Tuition fees: ");
                        double TuitionFees = Convert.ToDouble(Console.ReadLine());

                        var student = new Student
                        {
                            firstName = FirstName,
                            lastName = LastName,
                            dateOfBirth = DateOfBirth,
                            tuitionFees = TuitionFees
                        };
                        db.Students.Add(student);
                        db.SaveChanges();
                        Console.WriteLine("");
                        Console.WriteLine("LOADING...");
                        Console.WriteLine("");
                        Console.WriteLine("...DATA SUCCESSFULLY SAVED");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Please try again..\n");
                    }
                }
            }
        }

        public static void InsertCourse()
        {
            using (var db = new PrivateSchoolContext())
            {
                Console.WriteLine("Enter course details");
                Console.Write("Title: ");
                string Title = Console.ReadLine();
                Console.Write("Stream: ");
                string Stream = Console.ReadLine();
                Console.Write("Type: ");
                string Type = Console.ReadLine();
                Console.Write("Start date in format yyyy-MM-dd : ");
                DateTime Start_Date = Convert.ToDateTime(Console.ReadLine());
                Console.Write("End date in format yyyy-MM-dd : ");
                DateTime End_Date = Convert.ToDateTime(Console.ReadLine());

                var course = new Course
                {
                    title = Title,
                    stream = Stream,
                    type = Type,
                    start_date = Start_Date,
                    end_date = End_Date
                };
                db.Courses1.Add(course);
                db.SaveChanges();
                Console.WriteLine("");
                Console.WriteLine("LOADING...");
                Console.WriteLine("");
                Console.WriteLine("...DATA SUCCESSFULLY SAVED");
            }
        }

        public static void InsertTrainer()
        {
            using (var db = new PrivateSchoolContext())
            {
                Console.WriteLine("Enter trainer details");
                Console.Write("First name: ");
                string tFirstName = Console.ReadLine();
                Console.Write("Last name: ");
                string tLastName = Console.ReadLine();
                Console.Write("Subject (Python, Java, Csharp): ");
                string Subject = Console.ReadLine();
                Console.Write("Course Id: ");
                int CourseId =Convert.ToInt32(Console.ReadLine());


                var trainer = new Trainer
                {
                    firstName = tFirstName,
                    lastName = tLastName,
                    subject = Subject,
                    courseid = CourseId
                };
                db.Trainers.Add(trainer);
                db.SaveChanges();
                Console.WriteLine("");
                Console.WriteLine("LOADING...");
                Console.WriteLine("");
                Console.WriteLine("...DATA SUCCESSFULLY SAVED");
            }

        }

        public static void InsertAssignment()
        {
            using (var db = new PrivateSchoolContext())
            {
                Console.WriteLine("Enter assignment details");
                Console.Write("Title: ");
                string aTitle = Console.ReadLine();
                Console.Write("Description: ");
                string Description = Console.ReadLine();
                Console.Write("Submission date in format yyyy-MM-dd : ");
                DateTime Sub_Date = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Oral Mark: ");
                int OralMark = Convert.ToInt32(Console.ReadLine());
                Console.Write("Total Mark: ");
                int TotalMark = Convert.ToInt32(Console.ReadLine());
                Console.Write("Course Id: ");
                int CourseId = Convert.ToInt32(Console.ReadLine());

                var assignment = new Assignment
                {
                    title = aTitle,
                    description = Description,
                    sub_date = Sub_Date,
                    oralMark = OralMark,
                    totalMark = TotalMark,
                    courseid = CourseId
                };
                db.Assignments.Add(assignment);
                db.SaveChanges();
                Console.WriteLine("");
                Console.WriteLine("LOADING...");
                Console.WriteLine("");
                Console.WriteLine("...DATA SUCCESSFULLY SAVED");
            }
        }

        public static void InsertStudentsPerCourse()
        {
            using (var db = new PrivateSchoolContext())
            {
                try
                {
                    Console.WriteLine("Enter student id");
                    Console.Write("ID: ");
                    int sId = Convert.ToInt32(Console.ReadLine());
                    var student1 = db.Students.Where(s => s.id == sId).FirstOrDefault();
                    Console.WriteLine("Enter first course id");
                    Console.Write("ID: ");
                    int c1id = Convert.ToInt32(Console.ReadLine());
                    var course1 = db.Courses1.Where(c => c.id == c1id).FirstOrDefault();
                    student1.Courses.Add(course1);
                    db.SaveChanges();
                    Console.WriteLine("");
                    Console.WriteLine("LOADING...");
                    Console.WriteLine("");
                    Console.WriteLine("...DATA SUCCESSFULLY SAVED");

                    Console.WriteLine("Type 1 to insert second course for this student or 2 go back");
                    Console.Write("Please type number: ");
                    int decision;
                    decision = Convert.ToInt32(Console.ReadLine());
                    if (decision == 1)
                    {
                        Console.WriteLine("Enter second course id");
                        Console.Write("ID: ");
                        int c2id = Convert.ToInt32(Console.ReadLine());
                        var course2 = db.Courses1.Where(c => c.id == c2id).FirstOrDefault();
                        student1.Courses.Add(course2);
                        db.SaveChanges();
                        Console.WriteLine("");
                        Console.WriteLine("LOADING...");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("LOADING...");
                        Console.WriteLine("");
                        Console.WriteLine("...DATA SUCCESSFULLY SAVED");

                    }
                    else if (decision == 2)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input! Please try again..\n");
                    }
                    db.SaveChanges();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again..\n");
                }
            }
        }

        public static void InsertTrainersPerCourse()
        {
            using (var db = new PrivateSchoolContext())
            {
                try
                {
                    Console.WriteLine("Enter course id");
                    Console.Write("ID: ");
                    int c1id = Convert.ToInt32(Console.ReadLine());
                    var course1 = db.Courses1.Where(c => c.id == c1id).FirstOrDefault();
                    Console.WriteLine("Enter trainer id");
                    Console.Write("ID: ");
                    int tId = Convert.ToInt32(Console.ReadLine());
                    var trainer1 = db.Trainers.Where(t => t.id == tId).FirstOrDefault();
                    course1.Trainers.Add(trainer1);
                    db.SaveChanges();
                    Console.WriteLine("");
                    Console.WriteLine("LOADING...");
                    Console.WriteLine("");
                    Console.WriteLine("...DATA SUCCESSFULLY SAVED");

                    Console.WriteLine("Type 1 to insert another trainer for this course or 2 go back");
                    Console.Write("Please type number: ");
                    int decision;
                    decision = Convert.ToInt32(Console.ReadLine());
                    if (decision == 1)
                    {
                        Console.WriteLine("Enter trainer id");
                        Console.Write("ID: ");
                        int t2Id = Convert.ToInt32(Console.ReadLine());
                        var trainer2 = db.Trainers.Where(t => t.id == t2Id).FirstOrDefault();
                        course1.Trainers.Add(trainer2);
                        db.SaveChanges();
                        Console.WriteLine("");
                        Console.WriteLine("LOADING...");
                        Console.WriteLine("");
                        Console.WriteLine("...DATA SUCCESSFULLY SAVED");
                    }
                    else if (decision == 2)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input! Please try again..\n");
                    }
                    db.SaveChanges();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again..\n");
                }

            }
        }

        public static void InsertAssignmentPerStudentsPerCourse()
        {
            using (var db = new PrivateSchoolContext())
            {
                try
                {
                    Console.WriteLine("Enter student id");
                    Console.Write("ID: ");
                    int sId = Convert.ToInt32(Console.ReadLine());
                    var student1 = db.Students.Where(s => s.id == sId).FirstOrDefault();
                    Console.WriteLine("Enter first assignment id");
                    Console.Write("ID: ");
                    int a1id = Convert.ToInt32(Console.ReadLine());
                    var assignment1 = db.Assignments.Where(c => c.id == a1id).FirstOrDefault();
                    student1.Assignments.Add(assignment1);
                    db.SaveChanges();
                    Console.WriteLine("");
                    Console.WriteLine("LOADING...");
                    Console.WriteLine("");
                    Console.WriteLine("...DATA SUCCESSFULLY SAVED");

                    Console.WriteLine("Type 1 to insert another assignment for this student or 2 go back");
                    Console.Write("Please type number: ");
                    int decision;
                    decision = Convert.ToInt32(Console.ReadLine());
                    if (decision == 1)
                    {
                        Console.WriteLine("Enter second assignment id");
                        Console.Write("ID: ");
                        int a2id = Convert.ToInt32(Console.ReadLine());
                        var assignment2 = db.Assignments.Where(c => c.id == a2id).FirstOrDefault();
                        student1.Assignments.Add(assignment2);
                        db.SaveChanges();
                        Console.WriteLine("");
                        Console.WriteLine("LOADING...");
                        Console.WriteLine("");
                        Console.WriteLine("...DATA SUCCESSFULLY SAVED");
                    }
                    else if (decision == 2)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input! Please try again..\n");
                    }
                    db.SaveChanges();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again..\n");
                }
            }
        }
    }
}
