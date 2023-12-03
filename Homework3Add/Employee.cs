using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3Add
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public bool IsBusy { get; } = false;

        public abstract string OfficialDuties();
    }
}
