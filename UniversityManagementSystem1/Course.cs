using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem1
{
    class Course
    {
        public int N 
        { get; 
          set;
        }
        private string cName;

        public string CourseName
        {
            get { return cName; }
            set { cName = value; }
        }
        private int cId;

        public int CourseId 
        { get;
          set;
        }
      
        private int cCredit;

        public int CourseCredit
        {
            get { return cCredit; }
            set { cCredit = value; }
        }
        private double cTH;

        public double CourseTeachingHours
        {
            get { return cTH; }
            set { cTH = value; }
        }


        private Section[] sections;
        private int sC;

        public int SectionCount
        {
            get { return sC; }
            set { sC = value; }
        }

        public Course()
        {
            sections = new Section[10];
            sC = 0;
        }
        public Course(string cName, int cId, int cCredit, double cTH)
        {
            this.cName = cName;
            this.cId = cId;
            this.cCredit = cCredit;
            this.cTH = cTH;

            sections = new Section[10];
            sC = 0;
        }
        public Course(string cName, int cId, int cCredit, double cTH, int N)
        {
            this.cName = cName;
            this.cId = cId;
            this.cCredit = cCredit;
            this.cTH = cTH;
            this.N = N;
            sections = new Section[10];
            sC = 0;
        }
        public void AddScetion(params Section[] sections)
        {
            foreach (var a in sections)
            {
                if (sC < 20)
                {
                    this.sections[sC++] = a;
                }
                else
                {
                    Console.WriteLine("Add Section is not available  : " + a.CourseId);
                }
            }
        }
        public void ShowAllTheSections()
        {
            for (int i = 0; i < sC; i++)
            {
                sections[i].ShowInfo();
            }
        }
        public Section SearchSection(int sectionNumber)
        {
            Section a = null;
            for (int i = 0; i < sC; i++)
            {
                if (sections[i].CourseId.Equals(sectionNumber))
                {
                    a = sections[i];
                    break;
                }
            }
            return a;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name of the course: " + cName);
            Console.WriteLine("Id of the course : " + cId);
            Console.WriteLine("Credit Number of the course : " + cCredit);
            Console.WriteLine(" Hours of the course : " + cTH);
            

        }
        public void AddCourseNumber(int x)
        {
            N += x;
        }

    }
}