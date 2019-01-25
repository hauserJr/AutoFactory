using Autofac;
using Factory_Demo.Interface;
using Factory_Demo.Services;
using System;

namespace Factory_Demo
{
    class Program : RegisterDI
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var Fake_Login = Register<SLocalLogin, ITest>();
            Fake_Login.Write();

            var Fake_AD = Register<SADLogin, ITest>();
            Fake_AD.Write();

            var Fake_SSO = Register<SSSOLogin, ITest>();
            Fake_SSO.Write();


            Console.ReadLine();
        }
    }
}
