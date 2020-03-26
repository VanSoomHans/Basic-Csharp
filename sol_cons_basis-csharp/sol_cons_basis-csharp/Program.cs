﻿using System;
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













            Console.ReadLine();
            Console.ReadLine();


        }
    }
}
