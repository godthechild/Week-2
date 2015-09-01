using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2
{
    class Course
    {
        public string Name;
        private string courseID;
        public string CourseID
        {
            get { return courseID; }

            set
            {
                int n;
                bool isNumeric = int.TryParse(value, out n);

                if (value.Length == 6 && isNumeric) { courseID = value; }

                else { Console.WriteLine("{0}: error try setting invalid CourseID!", courseID); }
            }

        }
        public string Lecturer;
         private int num;
         public int NumStudents
    {
         get { return num; }
        set
        {
            if (value >= 0 && value <= MaxStudents)
            {
                num = value;
            }
            else
            {
                Console.WriteLine("{0}: error try setting invalid No. Students!", CourseID);
            }
        }
    }
         private int max;
         public int MaxStudents { 
             get{return max;}
            set
         {
             if (value >= NumStudents && value >= 0 && value <= 80)
             {
                 max = value;
             }
             else 
             {
                 Console.WriteLine("{0}: error try setting invalid Max No. Students!", CourseID);
             }
         }
         }
        public Course()
        {
            this.Name = "unknow";
            this.CourseID = "unknow";
            this.Lecturer = "staff";
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course(string n, string id)
        {
            this.Name = n;
            this.CourseID = id;
            this.Lecturer = "staff";
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course(string n, string id, string l)
        {
            this.Name = n;
            this.CourseID = id;
            this.Lecturer = l;
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course(string n, string id, string l, int m)
        {
            this.Name = n;
            this.CourseID = id;
            this.Lecturer = l;
            this.MaxStudents = m;
            this.NumStudents = 0;
        }
        public override string ToString()
        {
            return "[Course: " + Name + "( " + CourseID + ") , Lecturer= " + Lecturer + ", has " + NumStudents + "student , max=" + MaxStudents + "]";
        }
    }

}