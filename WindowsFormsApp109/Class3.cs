using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp109
{
    class cManager : IEmployee
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Concatinate()
        {
            return FirstName + " " + LastName + "0012";
        }
    }
}

