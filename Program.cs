using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    internal class Program
    {
        public static int calculateFactorial(int num)
        {
            if (num == 0)
                return 1;
            else
                return (num*calculateFactorial(num-1));
        }
        static void Main(string[] args)
        {
            another:
            try
            {
                Console.WriteLine("Enter the Task number to perform");
                Console.WriteLine("\t1. Hello World \n\t2. Variables and User Input \n\t3. Basic Arithmetic \n\t4. Control Structures \n\t5. Loops \n\t6. Arrays \n\t7. Methods \n\t8. Exception Handling");
                Console.Write("The number is ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Hello World!!!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the UserName");
                            string userName=Console.ReadLine();
                            Console.WriteLine($"Hello,{userName}!!!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Input 1");
                            int input1=int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Input 2");
                            int input2=int.Parse(Console.ReadLine());
                            Console.WriteLine("Addition : " + ( input1+ input2));
                            Console.WriteLine("Substraction : " + (input1 - input2));
                            Console.WriteLine("Multiplication : " + (input1 * input2));
                            Console.WriteLine("Division : " + (input1 / input2));
                            Console.WriteLine("Modulus : " + (input1 % input2));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the Number");
                            int number=int.Parse(Console.ReadLine());
                            if(number%2==0)
                                Console.WriteLine($"{number} is Even Number");
                            else
                                Console.WriteLine($"{number} is Odd Number");
                            break;
                        }
                    case 5:
                        {
                            for(int i=1;i<=10;i++)
                                Console.Write(i+"\t");
                            Console.WriteLine();
                            break;
                        }
                    case 6:
                        {
                            int[] array = { 5, 12, 30, 48, 12 };
                            int n = array.Length;
                            int sum = 0, avg = 0;
                            foreach(int i in array)
                            {
                                sum = sum + i;
                            }
                            Console.WriteLine("The Sum : "+sum);
                            avg = sum / n;
                            Console.WriteLine("The Average : "+avg);
                            
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter the Number");
                            int num = int.Parse(Console.ReadLine());
                            int fact;
                            if (num > 0)
                            {
                                fact = calculateFactorial(num);
                                Console.WriteLine($"The Factorial Number of {num} : {fact}");
                            }
                            else
                                Console.WriteLine("Not a Positive Number");
                            break;
                        }
                    case 8:
                        {
                            try
                            {
                                repeat:
                                Console.WriteLine("Enter the Age");
                                string word = Console.ReadLine();
                                int age;
                                bool convert = int.TryParse(word, out age);
                                if (!convert)
                                {
                                    Console.WriteLine("Enter the Valid Number");
                                    goto repeat;
                                }
                                else
                                {
                                    if(age<18)
                                        Console.WriteLine("The User is a Minor");
                                    else if(age>65)
                                        Console.WriteLine("The User is a Senior");
                                    else
                                        Console.WriteLine("The User is a Adult");
                                }
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the Correct Choice");
                            break;
                        }
                }
                Console.WriteLine("Would You Like to Perform another task?\n\t1. Yes \t2. No");
                int like = int.Parse(Console.ReadLine());
                if (like == 1)
                    goto another;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
