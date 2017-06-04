using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class NumbException : Exception
    {
        public string mess;
        public NumbException() {}
        public NumbException(string message)
        {
            this.mess = message;
        }
    }
}
