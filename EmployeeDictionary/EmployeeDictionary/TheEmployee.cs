using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class TheEmployee

    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public int Id { get; set; }
        public override string ToString()
        {
            return Id.ToString() + "," +
                FirstName + " " + LastName;
        }
    }
}
