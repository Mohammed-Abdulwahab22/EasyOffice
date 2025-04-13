using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EasyOffice_Access
{
    public class Class2
    {
        public static string Test1()
        {
            System.Configuration.ConfigurationManager.AppSettings["Test1"] = "Test1";
            return "Test1";
        }
    }
}
