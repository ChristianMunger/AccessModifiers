using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class BadClass
    {
        // bad practice to make everything public
        public string creditCardNumber;

        // better way to get and set private info
        // would return stars and only last 4 digits
        private string _ssn;
        public string SSN
        {
            get
            {
                return "***-**-1234";
            }
            set { _ssn = value; }
        }


        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 130)
                {
                    _age = value;
                }
            }
        }
    }
}
