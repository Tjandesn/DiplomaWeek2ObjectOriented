﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_OOP
{
    public class Student : Person
    {
        private int studentID;

        public Student(string pFName, string pLName, string pGender, int pStudentID) :base (pFName, pLName, pGender)
        {
            studentID = pStudentID;
        }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public override string Work()
        {
            return "Study, Drink Coffee, Party, Sleep, Repeat";
        }
    }
}
