using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a numberstring with caracters:");
            string str = Console.ReadLine();
            string subStr = "";
            int total = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                if(!char.IsNumber(str[i]))
                {
                    continue;
                }
        
                int number = (int)Char.GetNumericValue(str[i]);
                if (char.IsNumber(str[i]))
                {
                    subStr = char.ToString(str[i]);
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (!char.IsNumber(str[j]))
                        {
                            break;
                        }
                        if (char.IsNumber(str[j]))
                        {
                            int number1 = (int)Char.GetNumericValue(str[j]);
                            if (number != number1)
                            {
                              
                            }
                            else
                            {
                                int q = j - i+1;
                                subStr = str.Substring(i, q);
                                total = total + Int32.Parse(subStr);
                              
                                if (i>0)
                                {
                                    for(int n=0;n<i;n++)
                                    {
                                        Console.Write(str[n]);
                                    }
                                }
                                
                                for (int x = i; x < j+1; x++) 
                                {
                                    Console.ForegroundColor= ConsoleColor.Green;
                                    Console.Write(str[x]);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    int p = x;
                                }
                                for (int y = j; y < str.Length; y++)
                                {
                                    Console.Write(str[y]);
                                }
                                Console.WriteLine();
                                subStr = "";
                                break;
                                
                            }
                        }
                        else
                        {
                            
                        }
                     

                    }
                        
                }
               
            }
            Console.WriteLine("totalen är lika med: " + total);
            Console.ReadLine();
        }
            
    }
    
}

