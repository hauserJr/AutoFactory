using Factory_Demo.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Factory_Demo.Services
{
    public class SLocalLogin : ITest
    {
        public void Write()
        {
            Console.WriteLine("Local Login");
        
        }
    }
}