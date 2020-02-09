using System;
using System.Collections.Generic;
using System.Text;

namespace WebSystemscSharp
{
    class Student
    {
        private int grade;//User's Grade Level
        private String name;//User's Name

        public Student(int gradeLvL, String userName)//Student Constuctor 
        {
            gradeLvL = grade;//set student grade level in constructor 
            userName = name;//set student name in constructor
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }
    }
}






