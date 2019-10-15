using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseClass
    {

        // fields
        private int basePrivateInt;
        protected int baseProtectedInt;

        // constructors

        public BaseClass() { }

        public BaseClass (int privateInt, int protectedInt)
        {
            this.basePrivateInt = privateInt;
            this.baseProtectedInt = protectedInt;
        }

        //methods
        public void BaseMethod()
        {
            Console.WriteLine("BaseClass.BaseMethod");
        }

        // adding the word virtual 
        // virtual says i may override this
        // tells compiler I have children classes that may but don't have
        // to override this method
        public virtual void PrintState()
        {
            Console.WriteLine("BaseClass object");
            Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt);
            Console.WriteLine("\tbaseProtectedInt: {0}", baseProtectedInt);
        }
    }
}
