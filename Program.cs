using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The object of this program is to ask the user to enter 7 grades for tests
             * and then the program will sum those grades and average them.
             */

            //Declare and initialize variables
            Double dSum = 0.0;
            Double dAvg = 0.0;
            Double[] dGrades;
            String[] sNames;
            String sUserResp = String.Empty;
            Int32 iStudentCount = 0;

            //Determine number of students to have test scores
            Console.Write("How many students in the class? ");
            sUserResp = Console.ReadLine();
            try
            {
                iStudentCount = Convert.ToInt32(sUserResp);
            }
            catch(Exception ex)
            {
                Console.WriteLine("I beg your pardon, fool. You have entered invalid data.");
                Console.WriteLine(ex.Message);
                Pause("Program will now exit.");
                return;
            }

            dGrades = new Double[iStudentCount];
            sNames = new String[iStudentCount];

            Type arrayType = dGrades.GetType();
            if (arrayType.IsArray)
            {
                Pause("dGrades is an array of " + arrayType.ToString());
            }
            else
            {
                Pause("dGrades is NOT an array.");
            }
            //Start loop for data entry
            for (Int32 i = 0; i < iStudentCount; i++)
            {
                //Obtain a student name
                Console.Write("Enter a name for student #" + (i + 1).ToString() + ": ");
                sNames.SetValue(Console.ReadLine(), i);

                //Obtain that student's grade
                Console.Write("Enter a grade for student #" + (i + 1).ToString() + ": ");
                sUserResp = Console.ReadLine();
                try
                {
                    dGrades.SetValue(Convert.ToDouble(sUserResp), i);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("I beg your pardon, fool. You have entered invalid data.");
                    Console.WriteLine(ex.Message);
                    Pause("Program will now exit.");
                    return;
                }

                //Add this grade to the running sum
                dSum += dGrades[i];

            }
            //Average the grades
            dAvg = dSum / (Double)iStudentCount;

            Console.WriteLine("\nHere is the breakdown of our student grades:");
            for (Int32 i = 0; i < iStudentCount; i++)
            {
                Console.Write(sNames.GetValue(i) + ": ");
                Console.WriteLine(dGrades.GetValue(i).ToString());
            }

            //Output the average
            Pause("The average score is: " + dAvg.ToString() + 
                ".\nProgram will now exit.");
 
        } //End of main

        static void Pause(String s)
        {
            Console.WriteLine("\n" + s);
            Console.WriteLine("Press <enter> to close the program and window.");
            Console.ReadLine();
        }

        
    }
}
