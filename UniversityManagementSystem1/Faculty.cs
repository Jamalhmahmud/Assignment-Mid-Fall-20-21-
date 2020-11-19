using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem1
{
    class Faculty
    {
        public string FName
        { get; 
          
          set; 
        }
        public string FId
        { get; 
          set; 
        }
        Teaching_Hour[] teaching_Hours;
        public int CreditCount
        { get; 
          set; 
        }
        public Faculty()
        {
            teaching_Hours = new Teaching_Hour[100];
        }
        public Departments Departments
        { get; 
          set; 
        }

        public Faculty(string fName, string fId)
        {
            this.FName = fName;
            this.FId = fId;
            teaching_Hours = new Teaching_Hour[100];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + FName);
            Console.WriteLine("Id: " + FId);
            Console.ReadKey();
        }
        public void AddCredit(params Teaching_Hour[] teaching_Hour)
        {
            foreach (var a in teaching_Hour)
            {
                if (CreditCount < 7)
                {
                    this.teaching_Hours[CreditCount++] = a;

                }
                else
                {
                    Console.WriteLine("Can not Take More Than 21 Credits");
                    Console.WriteLine("Cannot take any more course : " + a.CreditCount);
                    
                }

            }


        }
        public void ShowAllCredits()
        {
            Console.WriteLine("********************************");
            for (int i = 0; i < CreditCount; i++)
            {
                teaching_Hours[i].ShowInfo();
            }
            Console.WriteLine("*******************************************************");
            
        }
    }
}