using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem1
{
    class Section : Course
    {
        private string sName;

        public string SectionName
        {
            get { return sName; }
            set { sName = value; }
        }
      
        public Section() { }
        public Section(string sName, string cName, int cId, int cCredit, double cTH) : base(cName, cId, cCredit, cTH)
        {
            this.sName = sName;
           
        }
        virtual public void ShowSectionInfo()
        {
            Console.WriteLine("Section Name : " + sName);
          

        }
    }
}