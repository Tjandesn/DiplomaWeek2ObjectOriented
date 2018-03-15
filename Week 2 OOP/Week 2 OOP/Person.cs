using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_OOP
{
    public abstract class Person
    {
        private string fName;
        private string gender;
        private string lName;

        public string GetGender()
        {
            return gender;
        }

        public virtual string GetOccupation()
        {
            return "Unemployed";
        }

        public Person(string pFName, string pLName, string pGender)
        {
            Fname = pFName;
            Lname = pLName;
            gender = pGender;

            switch (pGender)
            {
                case "F":
                    gender = pGender;
                    break;

                case "M":
                    gender = pGender;
                    break;

                default:
                    throw new InvalidOperationException("Invalid Gender Passed to Person Constructor");
            }
        }

        public Person(string pGender)
        {
            gender = pGender;

            switch (pGender)
            {
                case "M":
                    Fname = "John";
                    gender = pGender;
                    lName = "Doe";
                    break;

                case "F":
                    Fname = "Jane";
                    gender = pGender;
                    lName = "Doe";
                    break;

                default:
                    throw new InvalidOperationException("Invalid Gender Passed to Person Constructor");
            }
        }

        public abstract string Work();

        public string Fname
        {
            get { return fName; }
            set { fName = value; }
        }

        public string Lname
        {
            get { return lName; }
            set { lName = value; }
        }

    }
}
