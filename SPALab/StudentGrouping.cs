using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPALab
{
    class StudentGrouping
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            bool confirmDone = false;
            bool appOn = true;

            do
            {
                confirmDone = false;
                Console.WriteLine("Enter student name...");
                students.Add(Console.ReadLine());
                if (students.Last() == "")
                {
                    students.RemoveAt(students.Count - 1);
                    confirmDone = true;
                }
                do
                {
                    Console.WriteLine("{0}", confirmDone == true ? "Please enter a valid name." : "Add another student name? Y/N");
                    if (!confirmDone)
                    {

                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.Y:

                                confirmDone = true;

                                break;

                            case ConsoleKey.N:

                                confirmDone = true;
                                appOn = false;

                                break;
                        }
                    }
                } while (!confirmDone);
                Console.Write("\n");


            } while (appOn);

            //STUDENTS SHOULD BE PLACED IN GROUPS OF TWO.  IF There ... 
            Console.Clear();
            int count = students.Count;
            Console.WriteLine("---------------Students Paired into Groups of {0}.----------------------\n\n", count % 2 == 0 ? "two" : "two and three");
            List<string[]> groupList = new List<string[]>();

            int index = 0;
            do
            {
                if (count % 2 != 0)
                {
                    if (count > 1)
                    {
                        //write three
                        count -= 3;
                        Console.Write("{0}, {1}, {2}\n",
                            students[index++], students[index++], students[index++]);
                        
                    }
                    else
                    {
                        //write one AND be done
                        Console.Write("{0}\n", students[index++]);
                        count = 0;
                    }
                }
                else
                {
                    //write two
                    Console.Write("{0}, {1}\n",
                        students[index++], students[index++]);
                    count -= 2;
                }
            } while (count != 0);

        }
    }
}
