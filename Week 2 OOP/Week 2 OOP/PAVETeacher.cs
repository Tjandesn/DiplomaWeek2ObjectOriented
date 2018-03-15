using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_OOP
{
    class PAVETeacher : Teacher
    {
        public override string GetOccupation()
        {
            return "PAVE Teacher";
        }

        public PAVETeacher(int pStaffID, string pFName, string pLName, string pGender) :base(pStaffID, pFName, pLName, pGender)
        {
            TeachBehaviour = new TeachPAVE();
        }
    }
}
