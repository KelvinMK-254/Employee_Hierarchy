using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHierarchy
{
    class Exceptions : Exception
    {
        public Exceptions(string message) : base(message)
        {
        }
    }


    class SalaryInvalid : Exception
    {
        public SalaryInvalid(string message) : base(message)
        {
        }
    }
}
