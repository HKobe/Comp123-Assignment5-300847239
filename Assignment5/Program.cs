﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Adding the name space
using System.IO;
/*
 * Hassan Kobeissi - 300847239
 * Created: July 15th, 2016
 * Modified: July 17th, 2016
 * Purpose: Stores Student Grades in Text Files.
 */
namespace Assignment5
{
    /// <summary>
    /// Class: Program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {     
            FileStream fs1 = new FileStream("GradingFile.tXt", FileMode.OpenOrCreate, FileAccess.Write);
            using (TextWriter writer = new StreamWriter(fs1))
            {
                writer.Write("Kobeissi, Hassan: 300847239 Software Engineering, A+");
                writer.Write("Thomas, Xavier: 300847238 Software Engingeering,  F-");
                writer.Write("Ketchum, Ash: 300847237 Software Engineering, B+");
                writer.Close();
            }
            
            ShowMenu();
            Console.WriteLine();


        }
        static public void writer()
        {
          
        }
#region ShowMenu()
/// <summary>
/// Displays Option Menu for user, void, no params.
/// </summary>
///
static public void ShowMenu()
        {
            int menuchoice = 0;
            while (menuchoice != 3)
            {

                Console.WriteLine("~~~~~~~Grade Choices~~~~~~~~~");
                Console.WriteLine("Please select your option.");
                Console.WriteLine("        1. Display Grades");
                Console.WriteLine("        2. Exit");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("            Enter Choice : ");
                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 1:
                        Console.Write("File to Load? ");
                        
                        try
                        {
                            string userInput = Console.ReadLine();
                            ///If user inputs incorrect text name, display error message and redirect to menu.
                            if (userInput != "GradingFile.txt")
                            {
                                Console.WriteLine("No Such File");
                            }
                            else
                            {
                                FileStream fs1 = new FileStream("GradingFile.tXt", FileMode.OpenOrCreate, FileAccess.Read);
                                using (var reader = new StreamReader(fs1))
                                {
                                    var alltext = reader.ReadToEnd();
                                    reader.Read("Kobeissi, Hassan: 300847239 Software Engineering, A+");
                                   
                                }
                            }
                        }
                        catch
                        {

                        }
                        
                        break;
                    case 2:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Unknown value");
                }
            }

        }
        #endregion
    }
}
