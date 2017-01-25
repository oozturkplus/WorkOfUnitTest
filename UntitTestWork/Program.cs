using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UntitTestWork
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public bool IsValidLogFileName(string fileName)
        {
            if (fileName.EndsWith(".SLF"))
            {
                return false;
            }
            return true;
        }
    }
}
