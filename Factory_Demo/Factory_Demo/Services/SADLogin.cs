using Factory_Demo.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Factory_Demo.Services
{
    public class SADLogin : ITest
    {
        public void Write()
        {
            Console.WriteLine("AD Login");
        
        }
    }
}