using System;

namespace Dag2_assignment1
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            Assignment1 a = new Assignment1();

            // execute WritingToConsole
            /*
            a.WritingToConsole();
            a.StringManipulation();
            a.MathematicalOperatorsAndMethods();
            a.MathematicalOperatorsAndMethods_11();
            a.Selection();
            */

            a.Iteration();
            
            // 'please key to close' feature
            Console.WriteLine("Press any key to close the window!!");
            Console.ReadKey();

        }

        public void WritingToConsole()
        {
            // 1
            Console.WriteLine("Waseem Soomro");

            // 2
            String firstName = "Waseem";
            String lastName = "Soomro";
            Console.WriteLine(firstName + " " + lastName);

            // 3
            Console.WriteLine(DateTime.Now);
            //--- DateTime.Now get us the current date and time.

            // 4
            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            lastName = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName);
        }

        public void StringManipulation()
        {

            /* code on top of the page will this output:
            if you're doing your best, you won't have any time to worry about failure.
            */

            // 5
            Console.WriteLine("Enter your first name:");
            String firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            String lastName = Console.ReadLine();
            String fullName = firstName + " " + lastName;
            Console.WriteLine("Your name: " + fullName);

            // 6
            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            lastName = Console.ReadLine();
            fullName = firstName + " " + lastName;
            Console.WriteLine("Your name: " + fullName.ToUpper());

            // 7
            String str = "The quick fox Jumped Over the DOG";
            // code here            
            String str1 = (str.Substring(0, 1)).ToUpper();
            String str2 = (str.Substring(1, str.Length - 1)).ToLower();
            str = str1 + str2;
            Console.WriteLine(str);

            // 8
            str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";

            // Extracting the [1,2,3,4,5]
            String str_a = str.Substring(0, str.IndexOf("["));
            String str_b;
            String str_numbers = str.Substring(str.IndexOf("["));

            // removing values remove the values 2 and 3
            String str_numbers_4_5 = str_numbers.Substring(str_numbers.IndexOf("4"), 3) + ",";
            String str_numbers_1 = str_numbers.Substring(str_numbers.IndexOf("[1"), 3);

            // inserting 6 to 10 into it in the end, comma separated.
            String str_numbers_6_10 = "6,7,8,9,10]";
            str_b = str_numbers_1 + str_numbers_4_5 + str_numbers_6_10;
            str = str_a + str_b;
            Console.WriteLine(str);

            // 9
            //Extract the four sets (abc), (cba), (bac) and (cab) then print them on one line each in the console window

            str = "(abc) and (cba) are each others reverse! Same goes for (bac) and (cab)!";
            string str9a = str.Substring(str.IndexOf("(a") + 1, 3);
            string str9b = str.Substring(str.IndexOf("(cb") + 1, 3);
            string str9c = str.Substring(str.IndexOf("(b") + 1, 3);
            string str9d = str.Substring(str.IndexOf("(ca") + 1, 3);
            Console.WriteLine(str9a);
            Console.WriteLine(str9b);
            Console.WriteLine(str9c);
            Console.WriteLine(str9d);
        }

        public void MathematicalOperatorsAndMethods()
        {

            /*
            Why does following program not output the correct average of the two numbers given?
            int a = 10;
            double b = 2.0;
            double average = a + b / 2;
            Console.WriteLine(average);
            
            

        
            int a_math = 10;
            double b_math = 2.0;
            double average = (a_math + b_math) / 2;
            Console.WriteLine(average);
            //perentheses were missing.

            // 10
            int a = 10;
            int b = 3;
            int c = 7;
            int d = (int) (7 / 2.0f);
            double result = ((double) a / b) * 2;   
            Console.WriteLine(result);              // result: 6,66
            result = a / (b + c) + 9.0f;
            Console.WriteLine(result);      // result: 10
            result = a * a / (b + c);
            Console.WriteLine(result);      // result: 10
            result = a * (b + a) - 100;
            Console.WriteLine(result);      // result: 30
            
            */

            // 11
            // see MathematicalOperatorsAndMethods_11(int input)
        }

        public void MathematicalOperatorsAndMethods_11()
        {
            // reading from console, and parsing into int
            int n = int.Parse(Console.ReadLine());
            int sqrt_of_n;
            int square_2_of_n;
            int square_3_of_n;
            int square_10_of_n;
            Console.WriteLine(n);

            // calculating square root of n
            sqrt_of_n = (int)Math.Sqrt(n);
            // calculating square(s) of n
            square_2_of_n = (int)Math.Pow((double)n, 2);
            square_3_of_n = (int)Math.Pow((double)n, 3);
            square_10_of_n = (int)Math.Pow((double)n, 10);
            // writing-to-console the square(s) of n
            Console.WriteLine(square_2_of_n);
            Console.WriteLine(square_3_of_n);
            Console.WriteLine(square_10_of_n);
        }


        public void Selection()
        {
            
            // 12
            // reading name from Console
            string name_12 = Console.ReadLine();

            // checking if it is Bob or Alice
            if (name_12 == "Bob" | name_12 == "Alice")
            {
                Console.WriteLine("Hi {0}.", name_12);
            }


            // 13
            // taking number as input 
            int number_13 = int.Parse(Console.ReadLine());

            //checking whether this number is divisible by 4
            int divisible_value = number_13 % 4;

            if (divisible_value == 0)
            {
                Console.WriteLine("Yes, it is divisible by 4.");
            }
            else
            {
                Console.WriteLine("No, it is not divisible by 4. It is giving {0} remainder.", divisible_value);
            }
            

            // 14
            // storing the user typed text
            string user_input_text_14 = Console.ReadLine();
            // checking whether the word “city” occurs in the string
            int positin_of_text_occurance_14 = user_input_text_14.IndexOf("city");

            // display a message to the user at what position “city” occured
            if (positin_of_text_occurance_14 != -1)
            {
                Console.WriteLine("We have found \"City\" in the text at {0} position of index. \nFor no-technical folks, it's {1} character in text.", positin_of_text_occurance_14, positin_of_text_occurance_14+1);
            }
            else
            {
                Console.WriteLine("Sorry we have found \"City\" in the text.");
            }
            
            // 15
            // storing the user typed text
            string user_input_text_15 = Console.ReadLine();
            // checking whether the length of the string is greater than 25
            if (user_input_text_15.Length > 25)
            {
                Console.WriteLine("Yes, it's greater than 25.");
            }
            else
            {
                Console.WriteLine("No, it's not greater than 25.");
            }
            
            // 16
            int input_val_16;
            // Displaying 3 different options that the user can choose from
            Console.WriteLine("Please enter \n\"1\" to print \"Stockholm\", \n\"2\" to print \"Göteborg\" or \n\"3\" to print \"Sverige\" \nYour choice:");
            // saving user input
            input_val_16 = int.Parse(Console.ReadLine());
            

            // Removing the options after the choice.
            Console.Clear();

            // Displaying a different message, depending on the choice
            switch (input_val_16)
            {
                case 1:
                    Console.WriteLine("You entered 1.");
                    break;
                case 2:
                    Console.WriteLine("You entered 2.");
                    break;
                case 3:
                    Console.WriteLine("You entered 3.");
                    break;
                default:        // Display a message, if the choice is not valid
                    Console.WriteLine("Your choice is not valid.\n");
                    break;
            }
            
            

            // 17
            double result;
            // two numbers: a and b. & Convert them into integers
            Console.WriteLine("Please enter first number:");
            int inputVal_17_a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter se3cond number:");
            int inputVal_17_b = int.Parse(Console.ReadLine());
            //casting one of the integers to a double number
            double inputVal_17_a_Double = (double)inputVal_17_a;

            //result = a +b, a – b, a* b and a / b;
            result = inputVal_17_a_Double + inputVal_17_b;
            Console.WriteLine("Result of a + b is: {0}.", result);
            result = inputVal_17_a_Double - inputVal_17_b;
            Console.WriteLine("Result of a – b is: {0}.", result);

            // Make a check before dividing that b is not zero
            // display a message that it cannot be divided (if)
            // & show the result from a + b, a – b, a * b and a / b to the user with a descriptive label
            if (inputVal_17_b != 0)
            {
                result = inputVal_17_a_Double / inputVal_17_b;
                Console.WriteLine("Result of a / b is: {0}.", result);
            }
            else
            {
                Console.WriteLine("Second input value is zero. It can not be divided.");
            }
           
            // 18

            //user type in a number
            Console.WriteLine("Please enter a number:");
            int inputVal_18_a = int.Parse(Console.ReadLine());
            //Checking if the number is in the range 10 <= number <= 20
            if (10 <= inputVal_18_a)
            {
                Console.WriteLine("Yes, it is in the range 10 <=.");
                if (10 <= inputVal_18_a && inputVal_18_a <= 20) { 
                    Console.WriteLine("Yes, it is in the range <= 20.");
                }
            }
            else
            {
                Console.WriteLine("It's not in the range.");
            }
           

            // 19
            // taking user input of colour
            Console.WriteLine("Please enter colour name:");

            string inputVal_19_a = Console.ReadLine();
            // checking if the colour exists.
            // & printing out the name of the colour with the same colours.
            switch (inputVal_19_a)
            {
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}", inputVal_19_a);
                    break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0}", inputVal_19_a);
                    break;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0}", inputVal_19_a);
                    break;

                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0}", inputVal_19_a);
                    break;

                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}", inputVal_19_a);
                    break;

                default:
                    // If it doesn’t displaying an error message
                    Console.WriteLine("Error: Color not found!");
                    break;
            }
        }

        public void Iteration()
        {
            /*      #temporary comment to hide the code from execution

            

            // 20
            // Taking input of a number
            Console.WriteLine("Please enter a number:");
            int inputVal_20_a = int.Parse(Console.ReadLine());
            // checking if it's greater than zero
            if (inputVal_20_a > 0)
            {
                for (int i=0; i < inputVal_20_a; i++)
                {
                    Console.Write("{0}", i);
                    if (i != inputVal_20_a - 1 && i != (inputVal_20_a - 2))
                    {
                        Console.Write(",");
                    }
                    if (i == (inputVal_20_a - 2))
                    {
                        Console.Write(" and ");
                    }
                }
                Console.Write("\n.");
            }

            // 21
            // Taking input of a number
            Console.WriteLine("Please enter a number:");
            int inputVal_21_a = int.Parse(Console.ReadLine());
            // checking if it's greater than zero
            if (inputVal_21_a > 0)
            {

                for (int i = inputVal_21_a-1; i >= 0; i--)
                {
                    Console.Write("{0}", i);
                    if (i > 1)
                    {
                        Console.Write(",");
                    }
                    if (i == 1)
                    {
                        Console.Write(" and ");
                    }
                }
                Console.Write(".\n");
            }

            // 22
            // Taking input of a number
            Console.WriteLine("Please enter a number:");
            int inputVal_22_a = int.Parse(Console.ReadLine());
            // checking if it's greater than zero
            if (inputVal_22_a > 0)
            {

                for (int i = 0; i < inputVal_22_a; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("{0}\n", i);
                    }
                }
                
            }

            // 23

            int i_23 = 1;
            for(int i=0; i<10; i++) { 
                Console.Write("{0} ", i_23);
                i_23++;
            }
            Console.Write("\n");
            */

            int row_num_23_startPoint = 1;
            for (int j=1; j<11; j++) //run 10 times
            {
                for (int i = 0; i < 10; i++) //run 10 times
                {
                    Console.Write("{0} ", row_num_23_startPoint + j); //print row_num_23*2
                    row_num_23_startPoint++;
                }
                Console.Write("\n");
                row_num_23_startPoint = j++;
                //multiplication_num++;
            }
            Console.Write("\n");

            // 24

            for( int k=1; k<10; k++)
            {
                Console.Write("text");
            }
            // 25
            // 26
            // 27
            // 28
            // 29
            // 30
            // 31
            // 32
        }

        public void Arrays()
        {
            // 33
            // 34
            // 35
            // 36
            // 37
            // 38
            // 39
            // 40
            // 41
            // 42
            // 43
            // 44
            // 45
        }
    }

}
