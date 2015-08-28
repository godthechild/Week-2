using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        public string Name;
        public string StudentID;
        private int year;
        public int yearofbirth
        {
            get { return year; }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    year = value;
                    

                }
                else
                {
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!",StudentID);
                }
            }
        }
        public bool isActive;
        public Student()
        {
            this.Name = "John Doe";
            this.StudentID = "Unknown";
            this.yearofbirth = 1995;
            this.isActive = false;
        }
        public Student(string n,string id)
        {
            this.Name = n;
            this.StudentID = id;
            this.yearofbirth = 1995;
            this.isActive = true;
        }
        public Student(string n, string id,int year)
        {
            this.Name = n;
            this.StudentID = id;
            this.yearofbirth = year;
            this.isActive = true;
            
            
        }
        public Student(string Name, string StudentID, int YearOfBirth, bool isActive)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.yearofbirth = YearOfBirth;
            this.isActive = isActive;
        }

        public int getAge()
        {
            DateTime nyear = DateTime.Now;
            int y = yearofbirth;
            return nyear.Year - y;
        }
       
        public override string ToString()
        {
            string active;
            if (isActive == true)
            {
                active = "is active";
            }
            else
            {
                active = "is NOT active";
            }
            
            
                return "[Student: " + Name + "( " + StudentID + ") , age= " + getAge() + " ," + active + "]";
            
        }
   
    }
}
