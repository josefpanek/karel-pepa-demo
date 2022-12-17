using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Fundamentals.Tests")]

namespace Fundamentals
{
    public class PublicC
    {
        protected string name;
        private class PrivateC
        {

        }
        protected class ProtectedC
        {

        }
        internal protected class InternalProtectedC
        {

        }
    }
    
    internal class InternalC
    {

    }

    public class Inherited : PublicC
    {
        public Inherited()
        {
            Console.WriteLine(name);
        }
    }
}
