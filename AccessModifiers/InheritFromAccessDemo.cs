using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class InheritFromAccessDemo : AccessDemo
    {
        private void Test()
        {
            AccessDemo demo = new AccessDemo();
            demo.ProtectedInternalDemo(); // can access because class inherits AccessDemo and it is in the same project
            demo.InternalDemo(); // can access because class inherits AccessDemo
            

                    
        }
    }
}
