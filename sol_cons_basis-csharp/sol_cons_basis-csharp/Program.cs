using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_cons_basis_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datatypes

            bool mijnBool = false; // 1 bit, true of false
            int mijnInt = 0; // 4 bytes: Alle gehele getallen tussen  -2,147,483,648 to 2,147,483,647 
            double mijnDouble = 4.2; // 8 bytes: Alle decimale getallen tussen ...
            String mijnString = "Dit is mijn eerste String."; // 2 bytes per karakter
            char mijnChar = 'D'; // 2 bytes: kan 1 letter behouden
            DateTime mijnDateTime = DateTime.Now; // 8bytes: Over datums... 

             //// Date time now
             //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
             //// Add days to datetime Now
             //Console.WriteLine(DateTime.Now.AddDays(3).ToString("yyyy-MM-dd"));
             //// Remove days from datetime Now
             //Console.WriteLine(DateTime.Now.AddDays(-3).ToString("yyyy-MM-dd"));
             //// Format Datetime in different formats and display them  
             //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
             //Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
             //Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
             //Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
             //Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
             //Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
             //Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
             //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
             //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
             //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy H:mm"));
             //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy h:mm tt"));
             //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
             //Console.WriteLine(DateTime.Now.ToString("MMMM dd"));
             //Console.WriteLine(DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
             //Console.WriteLine(DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
             //Console.WriteLine(DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
             //Console.WriteLine(DateTime.Now.ToString("hh:mm tt"));
             //Console.WriteLine(DateTime.Now.ToString("H:mm"));
             //Console.WriteLine(DateTime.Now.ToString("h:mm tt"));
             //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
             //Console.WriteLine(DateTime.Now.ToString("yyyy MMMM"));
             /*
             01/13/2020
             2020-01-16
             2020-01-10
             01/13/2020
             Monday, 13 January 2020
             Monday, 13 January 2020
             Monday, 13 January 2020
             Monday, 13 January 2020
             Monday, 13 January 2020
             Monday, 13 January 2020 10:57:34
             01/13/2020 10:57
             01/13/2020 10:57 AM
             01/13/2020 10:57
             01/13/2020 10:57 AM
             01/13/2020 10:57:34
             January 13
             2020’-‘01’-‘13’T’10’:’57’:’34.3511433+00:00
             Mon, 13 Jan 2020 10’:’57’:’34 ‘G1T’
             2020’-‘01’-‘13’T’10’:’57’:’34
             10:57 AM
             10:57
             10:57 AM
             10:57:34
             2020 January
             */

        }
    }
}
