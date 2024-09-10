using System;
using System.IO;

namespace Enums_Kohnen_Christian
{

    enum Months                                                                                 //Makes the enumeration of Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
    class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Jun;                                                 //makes a BirthMonth method and calls from the enum
            int myBirthDay = 31;                                                                //Makes and assigns a BirthDay method
            int myBirthYear = 2006;                                                             //Makes and assigns a BirthYear method

            string myBirthDate = $"My Birthday in {myBirthMonth}/{myBirthDay}/{myBirthYear}";   //makes a string method (myBirthDate) that interpolates the three methods above

            File.WriteAllText("myFile.txt", "This is my File! Get out!\n");                     //creates a file that kindly tells thenm to go away then moves to the next line of the file
            Console.WriteLine(File.ReadAllText("myFile.txt"));                                  //reads the file and prints

            File.AppendAllText("myFile.txt", "No! You can't be in here either! GET OUT!!\n");   //appends the file then moves to the next line of the file
            Console.WriteLine(File.ReadAllText("myFile.txt"));                                  //reads the file and prints

            if (!File.Exists("newFile.txt"))                                                    //if the file newFile.txt doesn't exist, it copies mtFile to a newFile
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");                    //if the file newFile does exist, it replaces the newFile with myFile
            }
            
            File.AppendAllText("newFile.txt", myBirthDate);                                     //appends myBirthDate to the new file
            Console.WriteLine(File.ReadAllText("newFile.txt"));                                 //reads the file and prints
        }
    }
}