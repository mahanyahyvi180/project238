using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp109
{
    class cWorker
    {
        public string FirstName
        {
            get;
            set;
        }
        public string SocialSecurity
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
            return FirstName + ' ' + LastName;
        }
    }
}
