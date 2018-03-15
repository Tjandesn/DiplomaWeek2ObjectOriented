using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_OOP
{
    public abstract class Teacher : Person
    {
        private int staffID;
        protected ITeach TeachBehaviour;

        public override string GetOccupation()
        {
            return "Teacher";
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public Teacher(int pStaffID, string pFName, string pLName, string pGender) :base (pFName, pLName, pGender)
        {
            staffID = pStaffID;
        }

        public override string Work()
        {
            return "Teach, teach, teach, and stuff";
        }

    }
}
