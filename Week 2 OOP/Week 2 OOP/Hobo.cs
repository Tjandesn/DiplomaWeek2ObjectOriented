using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_OOP
{
    public class Hobo : Person
    {
        public Hobo(string pFName, string pLName, string pGender) : base(pFName, pLName, pGender)
        {

        }

        public Hobo(string pGender) : base(pGender)
        {

        }

        public override string Work()
        {
            return "Find A Place To Sleep";
        }
    }
}
