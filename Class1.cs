using System;
using System.Collections.Generic;
using System.Text;

namespace WebSystemscSharp
{
    class Student
    {
        public int grade { get; set;}//User's Grade Level
        public string name { get; set; }//User's Name

        public Student(int gradeLvL, String userName)//Student Constuctor 
        {
            gradeLvL = grade;//set student grade level in constructor 
            userName = name;//set student name in constructor
        }

        public override string ToString()
        {
            return base.ToString() + ": " + name.ToString();
        }

      



    }
}






