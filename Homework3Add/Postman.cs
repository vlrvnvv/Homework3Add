using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3Add
{
    public sealed class Postman : Employee
    {
        public bool IsBusy { get; set; }

        public override string OfficialDuties()
        {
            return "Развожу почту";
        }
    }
}
