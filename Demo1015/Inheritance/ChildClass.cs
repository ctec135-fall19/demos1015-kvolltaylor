using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ChildClass : BaseClass
    {

        // fields
        protected int childProtectedInt;

        // constructors
        public ChildClass() { }

        public ChildClass(int basePrivateInt, int baseProtectedInt, int childProtectedInt)
            // these two are using inherited constructors from BaseClass
            : base(basePrivateInt, baseProtectedInt)
        {
            this.childProtectedInt = childProtectedInt;
        }

        //methods
        public void ChildMethod()
        {
            Console.WriteLine("ChildClass.ChildMethod");
        }

        // what override does is say i'm redefining this method for the ChildClass
        // override says I know i've inherited this method but i'm going to 
        // override what my parent says
        public override void PrintState()
        {
            // including the below writeline can help you tell where you are
            // in the code and the hierarchy
            // using the print command can help you debug without using the debugger
            Console.WriteLine("ChildClass object");

            // demo of access: ChildClass has access to baseProtectedInt but not basePrivateInt
            //Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt);
            //Console.WriteLine("\tbaseProtectedInt: {0}", baseProtectedInt);

            Console.WriteLine("\tchildProtectedInt: {0}", childProtectedInt);
            base.PrintState();
        }
    }
}
