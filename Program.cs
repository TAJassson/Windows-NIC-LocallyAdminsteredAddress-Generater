using System;
using System.Diagnostics;
using Microsoft.Win32;

namespace LAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chars = "0123456789ABCDEF";
            var stringChars = new char[12];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            Console.WriteLine("New LAA Key "+ finalString);
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\ControlSet001\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\<iD>", true);
            // string data = key.GetValue("NetworkAddress").ToString();  //returns the text found in 'someValue'
            key.SetValue("NetworkAddress", finalString);
            string data = key.GetValue("NetworkAddress").ToString();
            Console.WriteLine();
            key.Close();
            Process.Start("ipconfig.exe", "/renew");
            Environment.Exit(0);
        }
    }
}
