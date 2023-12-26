using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Resources;

namespace FIT.WinForms.Helpers
{
    public class Resursi
    {
        static ResourceManager Manager = new ResourceManager("FIT.WinForms.Resource1", Assembly.GetExecutingAssembly());
        public static string Get(string name)
        {
            return Manager.GetString(name);
        }
    }
}
