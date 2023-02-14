using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrianow_backers_3isp9_18.ClassHelper
{
    internal class Class1
    {
        public class EFClass
        {
            public static DB.Entities Context { get; } = new DB.Entities();
        }
    }
}
