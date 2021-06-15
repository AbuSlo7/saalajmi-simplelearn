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
            // Welcome Message
            string welcome = $"############################################{Environment.NewLine}###### Welcome to the teacher system #######{Environment.NewLine}############################################";
            Console.WriteLine(welcome);
            // System service list
            string to_do = $"# What would you like to do? (Choose a number){Environment.NewLine} 1- Add new student{Environment.NewLine} 2- Get student data{Environment.NewLine} 3- Update student{Environment.NewLine} 4- Show all students";
            Console.WriteLine(to_do);
            string number_choose = Console.ReadLine();

            // Add new student
            if (number_choose == "1")
            {
                // file path should be created in C:// drive before running the app
                string file_path = @"C:\data.txt";
                List<string> txt_lines = new List<string>();            // creating a list to store txt data
                txt_lines = File.ReadAllLines(file_path).ToList();      // Reading the text by line
                Student student = new Student();                        // Student object to assign and store data
                Console.WriteLine("Type in the student ID number:");
                student.ID = Console.ReadLine();                        // to store student id from the user
                Console.WriteLine("Type in the student name:");
                student.Name = Console.ReadLine();                      // to store student name from the user
                Console.WriteLine("Type in the student class");
                student.Class = Console.ReadLine();                     // to store student class from the user
                Console.WriteLine("Type in the student section");
                student.Section = Console.ReadLine();                   // to store student section from the user

                // validating if user id exists it wont add the user
                string result = "";
                foreach (var line in txt_lines)
                {
                    string[] lineArray = line.Split(", ");
                    if (lineArray[0] == student.ID)
                    {
                        Console.WriteLine("# the user id already exists, try adding a new one");
                        result = lineArray[0];
                    }
                }
                if (result.Length == 0)
                {
                    txt_lines.Add($"{student.ID}, {student.Name}, {student.Class}, {student.Section}");    // assigning data to student object
                    File.WriteAllLines(file_path, txt_lines);                                              // to write data to txt file
                    Console.WriteLine("Student Record has been saved successfully");
                }

                // Get student data by id
            } else if (number_choose == "2")
            {
                Console.WriteLine("Type in the student ID:");
                string id = Console.ReadLine();                                                // getting the id to search for
                string file_path = @"C:\data.txt";                                             // getting all data from txt file
                List<string> txt_lines = new List<string>();
                txt_lines = File.ReadAllLines(file_path).ToList();
                string result = "";
                foreach (var line in txt_lines) {                                             // searching the id
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

                // update student
            } else if (number_choose == "3")
            {
                // sellection to choose what to update exactely
                string to_update = $"# What would you like to update? (Choose a number){Environment.NewLine} 1- Update student name{Environment.NewLine} 2- Update student class{Environment.NewLine} 3- Update student section{Environment.NewLine}";
                Console.WriteLine(to_update);
                string number_update_choose = Console.ReadLine();

                // update student name
                if (number_update_choose == "1") 
                {
                    Console.WriteLine("Type in the student ID:");
                    string id = Console.ReadLine();                            // getting the id to update the name
                    string file_path = @"C:\data.txt";
                    List<string> txt_lines = new List<string>();
                    txt_lines = File.ReadAllLines(file_path).ToList();
                    string result = "";                                        // to store the line with the id 
                    List<string> result_list = new List<string>();             // to store the other values without the selected id data
                    foreach (var line in txt_lines)
                    {
                        string[] lineArray = line.Split(", ");
                        if (lineArray[0] == id)
                        {
                            result = line;
                        } else
                        {
                            result_list.Add(line);
                        }
                    }
                    if (result.Length == 0)
                    {
                        Console.WriteLine("# There is no record meets your typed ID");
                    } else
                    {
                        Console.WriteLine("# Type in the updated student name");                    // to update the student name
                        string updated_name = Console.ReadLine();
                        string[] splitted_result = result.Split(", ");
                        result_list.Add($"{splitted_result[0]}, {updated_name}, {splitted_result[2]}, {splitted_result[3]}");
                        File.WriteAllLines(file_path, result_list);
                        Console.WriteLine("Student Record has been updated successfully");
                    }

                    // to update student calss
                } else if (number_update_choose == "2")
                {
                    Console.WriteLine("Type in the student ID:");
                    string id = Console.ReadLine();
                    string file_path = @"C:\data.txt";
                    List<string> txt_lines = new List<string>();
                    txt_lines = File.ReadAllLines(file_path).ToList();
                    string result = "";
                    List<string> result_list = new List<string>();
                    foreach (var line in txt_lines)
                    {
                        string[] lineArray = line.Split(", ");
                        if (lineArray[0] == id)
                        {
                            result = line;
                        }
                        else
                        {
                            result_list.Add(line);
                        }
                    }
                    if (result.Length == 0)
                    {
                        Console.WriteLine("# There is no record meets your typed ID");
                    }
                    else
                    {
                        Console.WriteLine("# Type in the updated student class");            // to update the studdent class
                        string updated_class = Console.ReadLine();
                        string[] splitted_result = result.Split(", ");
                        result_list.Add($"{splitted_result[0]}, {splitted_result[1]}, {updated_class}, {splitted_result[3]}");
                        File.WriteAllLines(file_path, result_list);
                        Console.WriteLine("Student Record has been updated successfully");
                    }

                    // tp update student section
                } else if (number_update_choose == "3")
                {
                    Console.WriteLine("Type in the student ID:");
                    string id = Console.ReadLine();
                    string file_path = @"C:\data.txt";
                    List<string> txt_lines = new List<string>();
                    txt_lines = File.ReadAllLines(file_path).ToList();
                    string result = "";
                    List<string> result_list = new List<string>();
                    foreach (var line in txt_lines)
                    {
                        string[] lineArray = line.Split(", ");
                        if (lineArray[0] == id)
                        {
                            result = line;
                        }
                        else
                        {
                            result_list.Add(line);
                        }
                    }
                    if (result.Length == 0)
                    {
                        Console.WriteLine("# There is no record meets your typed ID");
                    }
                    else
                    {
                        Console.WriteLine("# Type in the updated student name");
                        string updated_section = Console.ReadLine();                            // to update the studdent class
                        string[] splitted_result = result.Split(", ");
                        result_list.Add($"{splitted_result[0]}, {splitted_result[1]}, {splitted_result[2]}, {updated_section}");
                        File.WriteAllLines(file_path, result_list);
                        Console.WriteLine("Student Record has been updated successfully");
                    }
                } else
                {
                    Console.WriteLine("# you have not selected the right choice !");
                }



                // Get all data 
            } else if (number_choose == "4")
            {
                string file_path = @"C:\data.txt";
                List<string> txt_lines = new List<string>();
                txt_lines = File.ReadAllLines(file_path).ToList();
                Console.WriteLine("# Here the list of students");
                foreach (var line in txt_lines)
                {
                    Console.WriteLine(line);                                    // to console all data in the txt file
                }
            } else
            {
                Console.WriteLine("You have not choosen the right number");     // if not choosing the prooper number
            }
        }
    }
}
