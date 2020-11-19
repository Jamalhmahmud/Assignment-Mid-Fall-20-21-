using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("%%%%%%%%%%%%%%@@@@@@@@%%%%%%%%%%%%%%%");
            Console.WriteLine(":::::University_Management_System:::::");
            
         
            Course c = new Course("Java", 01, 3, 5.0, 1);
            Course c1 = new Course("C programming", 03, 3, 5.0, 1);

            Section s = new Section("A", "Java", 01, 3, 5.0);
            Section s1 = new Section("B", "Java", 01, 3, 3.0);
            Section s2 = new Section("C", "Java", 01, 3, 3.0);
            Section s3 = new Section("D", "Java", 01, 3, 3.0);
            Section s4 = new Section("E", "Java", 01, 3, 3.0);
            Section s5 = new Section("I", "C#", 02, 3, 3.0);
            Section s6 = new Section("J", "C#", 02, 3, 3.0);
            Section s7 = new Section("K", "C#", 02, 3, 3.0);
            Section s8 = new Section("L", "C#", 02, 3, 3.0);
            Section s9 = new Section("M", "C#", 02, 3, 3.0);
            s.SearchSection(01);

            Console.WriteLine(".............Seacrhing.......");
            c.SearchSection(01);
            Console.WriteLine("***************************************************");
            c.ShowInfo();
            Console.WriteLine("***********************************************");
            s.ShowInfo();
            Console.WriteLine("****************************************");

            Departments d = new Departments("FST");
            Departments d1 = new Departments("FE");
            Departments d2 = new Departments("FBA");
            Departments d3 = new Departments("FASS");

            d.AddCourse(c1, c);
            d.ShowAllCourses();

            Console.WriteLine("***************************************");
            Console.WriteLine("Adding Courses");

            d.AddCourse(s, s1, s2, s3, s4, s5, s6, s7, s8, s9);
            d.ShowAllCourses();

            Console.WriteLine("**********************************");
            Console.WriteLine("Faculty of the Courses");

            Faculty f = new Faculty("Tanvir Ahmed", "12-01");
            Faculty f1 = new Faculty("Fahad Molla", "18-02");
            Faculty f2 = new Faculty("Jamal Hossain", "16-03");
            Faculty f3 = new Faculty("Shahrukh Khan", "09-04");
            Faculty f4 = new Faculty("Sakib Al Hassan", "20-05");


            Teaching_Hour t = new Teaching_Hour("Java programming language", 3, d);
            Teaching_Hour t1 = new Teaching_Hour("C# programming language", 3, d);
            Teaching_Hour t2 = new Teaching_Hour("C programming language", 3, d);
            Teaching_Hour t3 = new Teaching_Hour("Python", 3, d);
            Teaching_Hour t4 = new Teaching_Hour("Operating System", 3, d);
            Teaching_Hour t5 = new Teaching_Hour("OOAD", 3, d);
            Teaching_Hour t6 = new Teaching_Hour("Accounting", 3, d2);
            Teaching_Hour t7 = new Teaching_Hour("COA", 3, d);
            Teaching_Hour t8 = new Teaching_Hour("Direct Current", 3, d1);
            Teaching_Hour t9 = new Teaching_Hour("Digital logic design", 3, d1);
            Teaching_Hour t10 = new Teaching_Hour("Alternating Current", 3, d1);
            Teaching_Hour t11 = new Teaching_Hour("Digital Electronics", 3, d1);
            Teaching_Hour t12 = new Teaching_Hour("Economics", 3, d2);
            Teaching_Hour t13 = new Teaching_Hour("Bussiness Math", 3, d2);
            Teaching_Hour t14 = new Teaching_Hour("Bussiness Communication", 3, d2);
            Teaching_Hour t15 = new Teaching_Hour("AC", 3, d3);
            Teaching_Hour t16 = new Teaching_Hour("DEC", 3, d3);
            Teaching_Hour t17 = new Teaching_Hour("DEC", 3, d3);
            Teaching_Hour t18 = new Teaching_Hour("AI", 3, d);
         

            Console.WriteLine("Information of the faculty");
            f.ShowInfo();
            f.AddCredit(t,t4, t15, t18);
            f.ShowAllCredits();
            Console.WriteLine("Faculty Information this time is :");
            f1.ShowInfo();
            f1.AddCredit(t, t1, t2, t3, t4, t5);
            f1.ShowAllCredits();
            Console.ReadKey();
        }
    }
}
