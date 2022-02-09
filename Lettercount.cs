using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Programming_Problem_Set_1
{
    internal class Lettercount
    {
        public String LetterCount(string s)
       
        {
            int count = 0; // Simply counting each char in the given word
            foreach (char c in s)
            {
                count++;
            }
            Console.WriteLine($"1. Letters in string 'Supercalifragilisticexpialidocious' are = {count}");
            return s;
        }

        public String WordFound(String s)
        {
            // Using Boolean operator to find whether 'ice' exist in the given word or not
            if (s.Contains("ice") == true)
            {
                Console.WriteLine("\n2.String 'Supercalifragilisticexpialidocious' contain substring 'ice'!");
            }
            else
            {
                Console.WriteLine("\n2. String 'Supercalifragilisticexpialidocious'does not contain substring 'ice'!");
            }

           return s;

        }

        public void LongestWord()
        {
            // Storing and printing out all 3 word for user convience 
            String str1 = "Supercalifragilisticexpialidocious";
            String str2 = "Honorificabilitudinitatibus";
            String str3 = "Bababadalgharaghtakamminarronnkonn";
            Console.WriteLine("\n3.-----Finding the Logest Word in given below Words-----");
            Console.WriteLine($"a. = {str1}");
            Console.WriteLine($"b. = {str2}");
            Console.WriteLine($"c. = {str3}");

            // Finding the length of the words to compare using the inbuilt function

            int str_1_Len=str1.Length;  
            int str_2_Len=str2.Length;
            int str_3_Len=str3.Length;

            // Printing out all 3 word's length for user convience 
            Console.WriteLine($"Length respectively are= {str_1_Len} ,{ str_2_Len} ,{ str_3_Len}");

            // Comparison logic 
            if (str_1_Len > str_2_Len && str_1_Len > str_3_Len)
            {
                Console.WriteLine("Word 'Supercalifragilisticexpialidocious' is the longest"); 
            }
            else if (str_2_Len > str_1_Len && str_2_Len > str_3_Len)
            {
                Console.WriteLine("Word 'Honorificabilitudinitatibus' is the longest");

            }
            else if (str_3_Len == str_1_Len )
            {
                Console.WriteLine("Word 'Supercalifragilisticexpialidocious' and 'Bababadalgharaghtakamminarronnkonn' are equal");
            }
            else if (str_3_Len == str_2_Len)
            {
                Console.WriteLine("Word 'Supercalifragilisticexpialidocious' and 'Honorificabilitudinitatibus' are equal");
            }
            else if (str_2_Len == str_2_Len)
            {
                Console.WriteLine("Word 'Bababadalgharaghtakamminarronnkonn' and 'Honorificabilitudinitatibus' are equal");
            }

            else
            {
                Console.WriteLine(" Word 'Bababadalgharaghtakamminarronnkonn' is the longest");
            }

        }

        public void Sorting()
        {
            // Storing all the words in an array
            string[] words ={"Berlioz", "Borodin", "Brian","Bartok", "Bellini", "Buxtehude", "Bernstein"};

            //Using Order by function to sort the words in the array
            String [] sorted_words=words.OrderBy(x => x).ToArray();
            Console.WriteLine("\n4.-------Sorted Composers are------ ");
            // Fetching each item from the sorted array (sorted_words)
            foreach (string word in sorted_words)
            {

                Console.WriteLine(word);
            }
            // Using First and Last function to print out the Fist and Last item of the sorted array
            String first=sorted_words.First();
            Console.WriteLine($" First Composer in dictionary would be = {first}");
            String Last=sorted_words.Last();
            Console.WriteLine($" Last Composer in dictionary would be = {Last}");
           
        }

    }
    
}
