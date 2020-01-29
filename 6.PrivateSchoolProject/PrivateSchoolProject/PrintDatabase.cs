using System;
using System.Linq;

namespace PrivateSchoolProject
{
    public static class PrintDatabase
    {
        public static void Output()
        {
            using (var db = new PrivateSchoolContext())
            {
                var query1 = from s in db.Students
                             select s;

                Console.WriteLine("\nLIST OF ALL THE STUDENTS");
                Console.WriteLine("---+-------------------------------+-------------------------------+-------------------+---------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Birth Date",-17} | {"Tuituin Fees"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+-------------------+---------------");
                foreach (var item in query1)
                {
                    Console.WriteLine($"{item.id,-3}| {item.firstName}| {item.lastName}| {item.dateOfBirth.ToString("dd/MM/yyyy"),-18}| {item.tuitionFees}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+-------------------+---------------");

                var query2 = from t in db.Trainers
                             select t;

                Console.WriteLine("\nLIST OF ALL THE TRAINERS");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Subject"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------");
                foreach (var item in query2)
                {
                    Console.WriteLine($"{item.id,-3}| {item.firstName,13}| {item.lastName,-16}| {item.subject}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------");

                var query3 = from a in db.Assignments
                             select a;

                Console.WriteLine("\nLIST OF ALL THE ASSIGNMENTS");
                Console.WriteLine("---+--------------------------------+-------------------------------+-------------------+----------+----------");
                Console.WriteLine($"{"ID",-2} | {"Title",-30} | {"Description",-29} |{"Submission Date",-18} |{"Oral Mark",-7} |{"Total Mark"} ");
                Console.WriteLine("---+--------------------------------+-------------------------------+-------------------+----------+----------");
                foreach (var item in query3)
                {
                    Console.WriteLine($"{item.id,-3}| {item.title} | {item.description}| {item.sub_date.ToString("dd/MM/yyyy"),-18}| {item.oralMark,-9}| {item.totalMark}");

                }
                Console.WriteLine("---+--------------------------------+-------------------------------+-------------------+----------+----------");

                var query4 = from c in db.Courses1
                             select c;

                Console.WriteLine("\nLIST OF ALL THE COURSES");
                Console.WriteLine("---+-------------------------------+-------------------------------+-------------------------------+-----------------+---------------");
                Console.WriteLine($"{"ID",-2} | {"Title",-29} | {"Stream",-29} |{"Type",-30} |{"Start Date",-16} |{"End Date"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+-------------------------------+-----------------+---------------");
                foreach (var item in query4)
                {
                    Console.WriteLine($"{item.id,-3}| {item.title}| {item.stream}| {item.type}| {item.start_date.ToString("dd/MM/yyyy"),-16}| {item.end_date.ToString("dd/MM/yyyy")}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+-------------------------------+-----------------+---------------");

                var query5 = from s in db.Students
                             from c in s.Courses
                             where c.id == 1
                             select new
                             {
                                 sId = s.id,
                                 sFirstName = s.firstName,
                                 sLastName = s.lastName,
                                 cTitle = c.title
                             };

                Console.WriteLine("\nLIST OF ALL THE STUDENTS PER COURSE");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query5)
                {
                    Console.WriteLine($"{item.sId,-3}| {item.sFirstName}| {item.sLastName}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query6 = from s in db.Students
                             from c in s.Courses
                             where c.id == 2
                             select new
                             {
                                 sId = s.id,
                                 sFirstName = s.firstName,
                                 sLastName = s.lastName,
                                 cTitle = c.title
                             };

                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query6)
                {
                    Console.WriteLine($"{item.sId,-3}| {item.sFirstName}| {item.sLastName}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query7 = from s in db.Students
                             from c in s.Courses
                             where c.id == 3
                             select new
                             {
                                 sId = s.id,
                                 sFirstName = s.firstName,
                                 sLastName = s.lastName,
                                 cTitle = c.title
                             };

                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query7)
                {
                    Console.WriteLine($"{item.sId,-3}| {item.sFirstName}| {item.sLastName}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query8 = from s in db.Students
                             from c in s.Courses
                             where c.id == 4
                             select new
                             {
                                 sId = s.id,
                                 sFirstName = s.firstName,
                                 sLastName = s.lastName,
                                 cTitle = c.title
                             };

                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query8)
                {
                    Console.WriteLine($"{item.sId,-3}| {item.sFirstName}| {item.sLastName}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query9 = from t in db.Trainers
                             from c in db.Courses1
                             where c.id == 1
                             select new
                             {
                                 tId = t.id,
                                 tFirstName = t.firstName,
                                 tLastName = t.lastName,
                                 cTitle = c.title
                             };

                Console.WriteLine("\nLIST OF ALL THE TRAINERS PER COURSE");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query9)
                {
                    Console.WriteLine($"{item.tId,-3}| {item.tFirstName}| {item.tLastName}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query10 = from t in db.Trainers
                              from c in db.Courses1
                              where c.id == 2
                              select new
                              {
                                  tId = t.id,
                                  tFirstName = t.firstName,
                                  tLastName = t.lastName,
                                  cTitle = c.title
                              };

                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query10)
                {
                    Console.WriteLine($"{item.tId,-3}| {item.tFirstName}| {item.tLastName}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query11 = from t in db.Trainers
                              from c in db.Courses1
                              where c.id == 3
                              select new
                              {
                                  tId = t.id,
                                  tFirstName = t.firstName,
                                  tLastName = t.lastName,
                                  cTitle = c.title
                              };

                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query11)
                {
                    Console.WriteLine($"{item.tId,-3}| {item.tFirstName}| {item.tLastName}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query12 = from t in db.Trainers
                              from c in db.Courses1
                              where c.id == 4
                              select new
                              {
                                  tId = t.id,
                                  tFirstName = t.firstName,
                                  tLastName = t.lastName,
                                  cTitle = c.title
                              };

                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29} | {"Last Name",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query12)
                {
                    Console.WriteLine($"{item.tId,-3}| {item.tFirstName}| {item.tLastName}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");


                var query13 = from a in db.Assignments
                              from c in db.Courses1
                              where c.id == 1
                              select new
                              {
                                  aId = a.id,
                                  aTitle = a.title,
                                  aDescription = a.description,
                                  cTitle = c.title
                              };

                Console.WriteLine("\nLIST OF ALL THE ASSIGNMENTS PER COURSE");
                Console.WriteLine("-----------------------------------CB8 CSHARP FULL TIME-------------------------------------");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"Title",-29} | {"Description",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query13)
                {
                    Console.WriteLine($"{item.aId,-3}| {item.aTitle}| {item.aDescription}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query14 = from a in db.Assignments
                              from c in db.Courses1
                              where c.id == 2
                              select new
                              {
                                  aId = a.id,
                                  aTitle = a.title,
                                  aDescription = a.description,
                                  cTitle = c.title
                              };

                Console.WriteLine("\n-----------------------------------CB8 CSHARP PART TIME-------------------------------------");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"Title",-29} | {"Description",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query14)
                {
                    Console.WriteLine($"{item.aId,-3}| {item.aTitle}| {item.aDescription}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query15 = from a in db.Assignments
                              from c in db.Courses1
                              where c.id == 3
                              select new
                              {
                                  aId = a.id,
                                  aTitle = a.title,
                                  aDescription = a.description,
                                  cTitle = c.title
                              };

                Console.WriteLine("\n-----------------------------------CB8 JAVA FULL TIME---------------------------------------");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"Title",-29} | {"Description",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query15)
                {
                    Console.WriteLine($"{item.aId,-3}| {item.aTitle}| {item.aDescription}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");

                var query16 = from a in db.Assignments
                              from c in db.Courses1
                              where c.id == 4
                              select new
                              {
                                  aId = a.id,
                                  aTitle = a.title,
                                  aDescription = a.description,
                                  cTitle = c.title
                              };

                Console.WriteLine("\n-----------------------------------CB8 JAVA PART TIME---------------------------------------");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                Console.WriteLine($"{"ID",-2} | {"Title",-29} | {"Description",-29} | {"Course Title"}");
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");
                foreach (var item in query16)
                {
                    Console.WriteLine($"{item.aId,-3}| {item.aTitle}| {item.aDescription}| {item.cTitle}");
                }
                Console.WriteLine("---+-------------------------------+-------------------------------+------------------------");


                var query17 =  from s in db.Students
                               from a in s.Assignments
                               where a.Courses.id==1
                               select new
                               {
                                   sId = s.id,
                                   sFirstName = s.firstName,
                                   sLastName = s.lastName,
                                   aTitle = a.title,
                                   aDescription = a.description,
                                   Ctitle = a.Courses.title
                               };

                Console.WriteLine("\nLIST OF ALL THE ASSIGNMENTS PER STUDENT PER COURSE");
                Console.WriteLine("------------------------------------------------------------------------CB8 CSHARP FULL TIME-----------------------------------------------------------------");
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29}| {"Last Name",-29} | {"Title",-29} | {"Description",-29} | {"Course Title"}");
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
                foreach (var item in query17)
                {
                    Console.WriteLine($"{item.sId,-3}|{item.sFirstName}|{item.sLastName} | {item.aTitle}| {item.aDescription}| {item.Ctitle}");
                }
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");

                var query18 = from s in db.Students
                              from a in s.Assignments
                              where a.Courses.id == 2
                              select new
                              {
                                  sId = s.id,
                                  sFirstName = s.firstName,
                                  sLastName = s.lastName,
                                  aTitle = a.title,
                                  aDescription = a.description,
                                  Ctitle = a.Courses.title
                              };


                Console.WriteLine("\n------------------------------------------------------------------------CB8 CSHARP PART TIME-----------------------------------------------------------------");
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29}| {"Last Name",-29} | {"Title",-29} | {"Description",-29} | {"Course Title"}");
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
                foreach (var item in query18)
                {
                    Console.WriteLine($"{item.sId,-3}|{item.sFirstName}| {item.sLastName}| {item.aTitle}| {item.aDescription}| {item.Ctitle}");
                }

                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");

                var query19 = from s in db.Students
                              from a in s.Assignments
                              where a.Courses.id == 3
                              select new
                              {
                                  sId = s.id,
                                  sFirstName = s.firstName,
                                  sLastName = s.lastName,
                                  aTitle = a.title,
                                  aDescription = a.description,
                                  Ctitle = a.Courses.title
                              };


                Console.WriteLine("\n--------------------------------------------------------------------------CB8 JAVA FULL TIME-----------------------------------------------------------------");
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29}| {"Last Name",-29} | {"Title",-29} | {"Description",-29} | {"Course Title"}");
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
                foreach (var item in query19)
                {
                    Console.WriteLine($"{item.sId,-3}|{item.sFirstName}| {item.sLastName}| {item.aTitle}| {item.aDescription}| {item.Ctitle}");
                }

                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");

                var query20 = from s in db.Students
                              from a in s.Assignments
                              where a.Courses.id == 4
                              select new
                              {
                                  sId = s.id,
                                  sFirstName = s.firstName,
                                  sLastName = s.lastName,
                                  aTitle = a.title,
                                  aDescription = a.description,
                                  Ctitle = a.Courses.title
                              };


                Console.WriteLine("\n--------------------------------------------------------------------------CB8 JAVA PART TIME-----------------------------------------------------------------");
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
                Console.WriteLine($"{"ID",-2} | {"First Name",-29}| {"Last Name",-29} | {"Title",-29} | {"Description",-29} | {"Course Title"}");
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
                foreach (var item in query20)
                {
                    Console.WriteLine($"{item.sId,-3}|{item.sFirstName}| {item.sLastName}| {item.aTitle}| {item.aDescription}| {item.Ctitle}");
                }
                Console.WriteLine("---+------------------------------+-------------------------------+-------------------------------+-------------------------------+--------------------------");
            }
        }
    }
}
