using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class AccessDemo
    {
        // private is only accessible in class or { } it was declared
        private void Demo()
        {
            PrivateDemo(); // notice Demo has access to PrivateDemo
        }
        private void PrivateDemo() { }
        private int test; // variables work the same... only allowed in this class

        private protected void PrivateProtectedDemo() { }

        // protected is accessible by this class and any method inside of a class that extends the base class
        // used in inheritance
        protected void ProtectedDemo() { }

        // available in same project AND any class that inherits this class
        protected internal void ProtectedInternalDemo() { }

        // internal scopes to entire project... for example this is accessible in AccessModifiers project
        // use for helper methods that you don't want exposed outside of a dll/project
        internal void InternalDemo() { }

        // public is accessible everywhere
        public void PublicDemo() { }
    }
}
