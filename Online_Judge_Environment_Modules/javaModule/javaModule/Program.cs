using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javaModule
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1, s2;
            if (args.Length > 0)
            {
                s1 = args[0]; s2 = s1 + ".java";
            }
            else
            {
                s2 = "test.java";
                s1 = "test";
            }
            Process compile = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "bats\\Compile_java.bat",
                    //Arguments = "test.java",
                    Arguments = s2,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            Process execute = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "bats\\Execute_java.bat",
                    //Arguments = "test",
                    Arguments = s1,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

         
            compile.Start();
            System.Threading.Thread.Sleep(1000);
            execute.Start();

        }
    }
}
