using System.Diagnostics;
using System.Security.Cryptography;

namespace SAST
{
    public class Class1
    {
        //commands in PATH is security-sensitive
        private void CommandsPath()
        {
            var a1 = new A1();
            a1.Print();
            var a2 = new A2();
            a2.Print();
            var a3 = new A3();
            a3.Print();
            var a4 = new A4();
            a4.Print();
            Process p = new Process();
            p.StartInfo.FileName = "binary"; // Sensitive kk
        }

        public void WeekHash()
        {
            var hashProvider1 = new MD5CryptoServiceProvider(); // Sensitive
            var hashProvider2 = (HashAlgorithm)CryptoConfig.CreateFromName("MD5"); // Sensitive
            var hashProvider3 = new SHA1Managed(); // Sensitive
            var hashProvider4 = HashAlgorithm.Create("SHA1"); // Sensitive
        }
        
        public void PlainPassword()
        {
            string password = "pass1";
        }


    }
    
    
    public class A1 { public void Print() { System.Console.WriteLine("a1"); } }
    public class A2 { public void Print() { System.Console.WriteLine("a2"); } }
    public class A3 { public void Print() { System.Console.WriteLine("a3"); } }
    public class A4 { public void Print() { System.Console.WriteLine("a4"); } }
}
