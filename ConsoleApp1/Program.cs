using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Teacher> lst1 = new List<Teacher>();
            //Console.WriteLine("https://github.com/AmeerahBaabdullah/TeacherSystem");

            string filepath = "d:/teacher.txt";


            int c = 1;
            do
            {
                Console.WriteLine("Enter Teacher Info:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Class: ");
                string classn = Console.ReadLine();
                Console.Write("Section:");
                string section = Console.ReadLine();
                lst1.Add(new Teacher(id, name, classn, section));


                Console.WriteLine("Add Another? 1 for continue , any key for exit");
                c = int.Parse(Console.ReadLine());



            } while (c == 1);

            //Add Teachers to File;
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                foreach (Teacher t in lst1)
                {
                    writer.WriteLine(t.BuildFileRow());
                    Console.WriteLine(t.Name + "Added Success");
                }
            }



            Console.WriteLine("All teacher Written on File " + filepath);


            Console.WriteLine("Read From c:/ Teachers.txt");

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(filepath))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Teacher t = new Teacher(line);
                        t.printInfo();
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }





        }
    }
}
