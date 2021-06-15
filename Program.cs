using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace saalajmi
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = $"############################################{Environment.NewLine}###### Welcome to the teacher system #######{Environment.NewLine}############################################";
            Console.WriteLine(welcome);
            string to_do = $"# What would you like to do? (Choose a number){Environment.NewLine} 1- Add new student{Environment.NewLine} 2- Get student data{Environment.NewLine} 3- Update student{Environment.NewLine} 4- Show all students";
            Console.WriteLine(to_do);
            string number_choose = Console.ReadLine();
            if (number_choose == "1")
            {
                string file_path = @"C:\data.txt";
                List<string> txt_lines = new List<string>();
                txt_lines = File.ReadAllLines(file_path).ToList();
                Student student = new Student();
                Console.WriteLine("Type in the student ID number:");
                student.ID = Console.ReadLine();
                Console.WriteLine("Type in the student name:");
                student.Name = Console.ReadLine();
                Console.WriteLine("Type in the student class");
                student.Class = Console.ReadLine();
                Console.WriteLine("Type in the student section");
                student.Section = Console.ReadLine();
                txt_lines.Add($"{student.ID}, {student.Name}, {student.Class}, {student.Section}");
                File.WriteAllLines(file_path, txt_lines);
                Console.WriteLine("Student Record has been saved successfully");

            } else if (number_choose == "2")
            {
                Console.WriteLine("Type in the student ID:");
                string id = Console.ReadLine();
                string file_path = @"C:\data.txt";
                List<string> txt_lines = new List<string>();
                txt_lines = File.ReadAllLines(file_path).ToList();
                string result = "";
                foreach (var line in txt_lines) {
                    string[] lineArray = line.Split(", ");
                    if (lineArray[0] == id)
                    {
                        Console.WriteLine("# Search result shows the following records:");
                        Console.WriteLine(line);
                        result = id;
                    }
                }
                if (result.Length == 0)
                {
                    Console.WriteLine("# There is no record meets your typed ID");
                }

            } else if (number_choose == "3")
            {
                string to_update = $"# What would you like to update? (Choose a number){Environment.NewLine} 1- Update student name{Environment.NewLine} 2- Update student class{Environment.NewLine} 3- Update student section{Environment.NewLine}";
                Console.WriteLine(to_update);
                string number_update_choose = Console.ReadLine();


            } else if (number_choose == "4")
            {
                string file_path = @"C:\data.txt";
                List<string> txt_lines = new List<string>();
                txt_lines = File.ReadAllLines(file_path).ToList();
                Console.WriteLine("# Here the list of students");
                foreach (var line in txt_lines)
                {
                    Console.WriteLine(line);
                }
            } else
            {
                Console.WriteLine("You have not choosen the right number");
            }
        }
    }
}
