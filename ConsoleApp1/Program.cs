using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using static SingleLinkedListStudentManagment.Student;

namespace SingleLinkedListStudentManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Student> singleLinkedList = new LinkedList<Student>();
            //singleLinkedList.AddLast(new Student(1, "Hoang",19, "nam", 2000));
            //singleLinkedList.AddFirst(new Student(2, "Hoang1", 19, "nam", 2000));
            //singleLinkedList.AddLast(new Student(3, "Hoang2", 19, "nam", 2000));
            //singleLinkedList.AddLast(new Student(4, "Hoang3", 19, "nam", 2000));
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------- ------------------- &&&& ---- Welcome to the student management system ---- &&&& -------------- -----------------------------------------------");
                Console.WriteLine("--------------   -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("------------------------------------------------- this system has the following operating -------------------------------- ------------- -------------------------------------------------- --------------------- ");
                Console.WriteLine("---- 1. View Student  ----");
                Console.WriteLine();
                Console.WriteLine("---- 2. Quit student management system ----");
                Console.WriteLine();
                //Console.WriteLine("----" "" "Please enter 1--5 numbers" "" "----");
                //Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                string w = Console.ReadLine().Trim();
                if (w.Equals("1"))
                {
                    StudentManagment();
                    break;
                }
                else if (w.Equals("2"))
                {
                    Console.WriteLine("Thanks you to visit our Student MG");
                    break;
                }   
                else
                {

                    Console.WriteLine("Oops Somethings happened....");
                    break;
                }
            }
        }
        static void StudentManagment()
        {
            string w = "";
            do
            {
                LinkedList<Student> singleLinkedList = new LinkedList<Student>();
                Console.WriteLine("---- 1. View Student Information ----");
                Console.WriteLine();
                Console.WriteLine("---- 2. Increase student information ----");
                Console.WriteLine();
                Console.WriteLine("---- 3 ---- modify student information.");
                Console.WriteLine();
                Console.WriteLine("---- 4 ---- delete student information.");
                Console.WriteLine();
                Console.WriteLine("---- 5 ---- RET");
                Console.WriteLine();
                Console.WriteLine("---- 6. Quit student management system ----");
                Console.WriteLine();
                w = Console.ReadLine().Trim();
                if (w.Equals("1"))
                {
                    ShowListInformation(singleLinkedList);
                }

                else if (w.Equals("2"))
                {
                    IncreaseStudent(singleLinkedList);
                }
            }
            while (w != "6");
        }
        static void ShowListInformation(LinkedList<Student> singleLinkedList)
        {
            Console.WriteLine("StudentList:");
            foreach (var stu in singleLinkedList)
            {
                ShowStudentInformation(stu);
            }
            Console.ReadLine();
        }

        static void ShowStudentInformation(Student student)
        {
            Console.WriteLine("ID:{0}", student.Mssv);
            Console.WriteLine("Student Name:{0}", student.Ten);
            Console.WriteLine("Age:{0}", student.Tuoi);
            Console.WriteLine("Gender:{0}", student.GioiTinh);
            Console.WriteLine("Course:{0}", student.Khoa);
        }


        static void IncreaseStudent(LinkedList<Student> singleLinkedList)
        {
            string s = "";
            do
            {
                Console.WriteLine("%----------------------------%");
                Console.WriteLine("1. Increase student information.");
                Console.WriteLine("2. Return to the previous menu.");
                Console.WriteLine("Please enter the number of 1--2");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                s = Console.ReadLine().Trim();
                if (s.Equals("1"))
                {
                    Student student = new Student();
                    student.Mssv = singleLinkedList.Count + 1;
                    Console.WriteLine("Input student name:");
                    string name = Console.ReadLine();
                    student.Ten = name;
                    Console.WriteLine("\n Input student age:");
                    string age = Console.ReadLine();   
                    bool success = false;
                    do
                    {
                        int intAge;
                        success = int.TryParse(age, out intAge);
                        if(success == false)
                        {
                            Console.WriteLine("Pls enter agains");
                            age = Console.ReadLine();
                            student.Tuoi = int.Parse(age);
                        } else
                        {
                            student.Tuoi = int.Parse(age);
                        }
                        

                    } while (success == true);
                    
                    Console.WriteLine("\n Input 1 is male | 2 is female");
                    int gender = int.Parse(Console.ReadLine());
                    if (gender == 1)
                    {
                        student.GioiTinh = "Male";
                    }
                    else
                    {
                        student.GioiTinh = "Female";
                    }
                    Console.WriteLine("\n Input student course:");
                    string khoa = Console.ReadLine();
                    student.Khoa = int.Parse(khoa);
                    singleLinkedList.AddLast(student);
                    ShowListInformation(singleLinkedList);
                    Console.WriteLine("\n Insert succesfull!!");
                }
            }
            while (s != "2");
        }
    }  
}



 
