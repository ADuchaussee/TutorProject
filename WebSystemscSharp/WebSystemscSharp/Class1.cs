using System;
using System.Collections.Generic;
using System.Text;

namespace WebSystemscSharp
{
    class Student
    {
        public int grade { get; set;}//User's Grade Level
        public string name { get; set; }//User's Name

        public Student()//Student Constuctor 
        {

        }

        public override string ToString()
        {
            return base.ToString() + ": " + name.ToString();
        }

      



    }
}






