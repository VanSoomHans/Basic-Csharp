using System;
using System.Collections.Generic;
using System.IO;
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

            
            
            
            //Operatoren
            /*
             1. Arithmetic Operators

            +Addition    Adds together two values        x + y
            - Subtraction Subtracts one value from another x -y
            * Multiplication  Multiplies two values x *y
            / Division    Divides one value from another x / y
            % Modulus Returns the division remainder          x % y
            ++  Increment Increases the value of a variable by 1  x++
            --  Decrement Decreases the value of a variable by 1  x--

            2. Assignment Operators
            +=	x += 3	x = x + 3	
            -=	x -= 3	x = x - 3

            3. Comparison Operators
            ==	Equal to	x == y	
            !=	Not equal	x != y	
            >	Greater than	x > y	
            <	Less than	x < y	
            >=	Greater than or equal to	x >= y	
            <=	Less than or equal to	x <= y

            4. Logical Operators
            && 	AND returns true als beide statements true zijn                                     x > 5 &&  x < 10	
            || 	OR returns true als één van de twee statements true zijn	                        x < 5 || x > 4	
            !	NOT, als het statement 'waar' is, moet je lezen als het NIET 'waar' is, dan true    !(x > 5 && x < 10)
            */

            mijnInt = 5;
            mijnDouble = 2;
            Console.WriteLine(mijnInt % mijnDouble); //5 / 2 = rest 1



            //Math klasse
            Console.WriteLine(Math.Max(5, 10));     //Geeft het hoogste getal terug
            Console.WriteLine(Math.Min(5, 10));     //Geeft het laagste getal terug
            Console.WriteLine(Math.Sqrt(64));       //Geeft de vierkantwortel terug
            Console.WriteLine(Math.Abs(-4.7));      //Geeft de absolute waarde terug
            Console.WriteLine(Math.Round(9.99));    //Geeft de een afgerond getal terug
            Console.WriteLine(Math.Pow(3, 2));      //Geeft het getal tot de macht x terug



            //Random
            Random mijnRandom = new Random();
            Console.WriteLine(mijnRandom.Next());            //Geeft een random getal terug
            Console.WriteLine(mijnRandom.Next(101));         //Geeft een getal terug tussen 0 en 100
            Console.WriteLine(mijnRandom.Next(50, 101));      //Geeft een getal terug tussen 50 en 100
            Console.WriteLine(mijnRandom.NextDouble());      //Geeft een double getal terug
            Console.WriteLine((mijnRandom.NextDouble() * 5));  //Geeft een double getal terug tussen 0 en 5
            Console.WriteLine((mijnRandom.NextDouble() * 5).ToString("0.00"));  //Geeft een double getal terug tussen 0 en 5 met 2 cijfers na de komma



            // Logische structuren

            Console.Write("Uw getal is ");
            if (mijnRandom.Next(10) > 5)
            {
                Console.Write("groter dan ");
            }
            else
            {
                Console.Write("kleiner dan ");
            }
            Console.Write("vijf. Proficiat!");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            mijnInt = 0;
            while (mijnInt < 10)
            {
                if (mijnInt == 4)
                {
                    mijnInt++;
                    break;
                }
                Console.WriteLine(mijnInt);
                mijnInt++;
            }
            //0 1 2 3   Bij de break gaat hij 'eruit'

            mijnInt = 0;
            while (mijnInt < 10)
            {
                if (mijnInt == 4)
                {
                    mijnInt++;
                    continue;
                }
                Console.WriteLine(mijnInt);
                mijnInt++;
            }
            //0 1 2 3    ...    5 6 7 8 9 'Bij continue gaat hij terug naar het begin'

            mijnInt = 0;
            do
            {
                Console.WriteLine(mijnInt);
                mijnInt++;
            }
            while (mijnInt < 5);
            //0 1 2 3 4

            int day = 9;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Thursday" (day 4)

          
            
            
            /*BESTANDEN
           •	Bestaat een bestand ?

               LEZEN   
               •	Alles in een keer lezen.
               •	Lijn per lijn lezen.
               •	Lijn per lijn maar deel van een lijn splitsen.

               SCHRIJVEN

           */
            //Alles in een keer lezen.
            Console.WriteLine("Lezen in 1 blok tekst om te 'displayen'");
            Console.ReadLine();
            // declaratie
            //Using system.IO
            if (System.IO.File.Exists("gegevens.txt"))
            {
                StreamReader leesobject = new StreamReader("gegevens.txt"); // dit wil zeggen, bestand bevind zich in de map debug
                string inhoud = "";
                //inhoud = leesobject.ReadLine();Leest enkel de eerste lijn, hier staat geen while not end of stream! Dus het stopt met lezen.
                inhoud = leesobject.ReadToEnd();
                // bestand sluitenn abders kunnen andere applicaties het niet gebruiken
                leesobject.Close();
                // inhoud neerschrijven op console
                Console.Write(inhoud.ToUpper());
            }
            else
            {
                Console.WriteLine("Het bestand werd niet gevonden en kan dus niet worden ingelezen.");
            }
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Lezen lijn per lijn om te 'displayen'");
            Console.ReadLine();
            string strgegeven;
            string result = "";
            StreamReader leesobject2 = new StreamReader("gegevens.txt");
            while (!leesobject2.EndOfStream)
            {
                strgegeven = leesobject2.ReadLine();
                Console.Write(strgegeven);
                Console.Read();
                result += strgegeven + Environment.NewLine;
            }
            leesobject2.Close();

            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Lezen lijn per lijn EN opsplitsen om te 'displayen'");
            Console.ReadLine();
            string strvoornaam, strfamilienaam;
            int intpositie;

            StreamReader leesobject3 = new StreamReader("namen.txt");
            while (leesobject3.Peek() != -1)
            {
                strgegeven = leesobject3.ReadLine();
                intpositie = strgegeven.IndexOf(",");
                strfamilienaam = strgegeven.Substring(0, intpositie);
                strvoornaam = strgegeven.Substring(intpositie + 1);
                Console.Write(strfamilienaam.PadLeft(15) + strvoornaam.PadLeft(15));
                Console.ReadLine();
            }
            leesobject3.Close();

            Console.ReadLine();
            Console.ReadLine();


            //SCHRIJVEN
            using (StreamWriter writer = new StreamWriter("gegevens2.txt"))
            {
                writer.WriteLine(result);
                Console.WriteLine("Uw bestand gegevens2.txt is weggeschreven.");

            }




            //ARRAYS
            //Maken, opsommen, toevoegen, wijzigen, verwijderen

            string[] arrayFietsen; //Als je nog niet weet hoelang je array zal zijn.

            arrayFietsen = new string[] { "koersfiets", "MTB", "Citybike" }; //Let op, als de array eenmaal een lengte heeft, kan deze niet 'zomaar' veranderd worden!
            Console.WriteLine(arrayFietsen.Length);
            arrayFietsen[1] = "test fiets"; //Zorgt voor wijziging van MTB naar test fiets

            try
            {
                arrayFietsen[3] = "test fiets";
                Console.Write(arrayFietsen.Length);
            }
            catch
            {
                Console.WriteLine("FOUTMELDING: arrayFietsen[3] = 'test fiets';" + Environment.NewLine + "Console.Write(arrayFietsen.Length);" + Environment.NewLine + "Bovenstaande werkt niet. Eerst een resize doen dan!");
            }

            //Nu gaat "test fiets" wel doen wat gevraagd is
            Array.Resize(ref arrayFietsen, 4);
            arrayFietsen[3] = "test fiets";
            Console.WriteLine(arrayFietsen.Length);

            foreach (string i in arrayFietsen)
            {
                Console.WriteLine(i);
            }

            //Een array sorteren 
            Console.ReadLine();
            Array.Sort(arrayFietsen);
            foreach (string i in arrayFietsen)
            {
                Console.WriteLine(i);
            }

            //Een array met numbers
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements






            Console.ReadLine();
            Console.ReadLine();


        }
    }
}
