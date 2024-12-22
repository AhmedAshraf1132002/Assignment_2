using System.Drawing;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter th Number");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion

            #region Q3
            //Console.WriteLine("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter third number: ");
            //int num3 = int.Parse(Console.ReadLine());


            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));


            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");
            #endregion

            #region Q4
            //Console.WriteLine("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());


            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}
            #endregion

            #region Q5
            //char character = char.Parse(Console.ReadLine().ToLower());


            //if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion

            #region Q6
            //Console.WriteLine("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i == number)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + ", ");
            //    }
            //}
            #endregion

            #region Q7

            //Console.WriteLine("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number * i);
            //    if (i < 5)
            //    {
            //        Console.WriteLine("a multiplication table up to 12. "); 
            //    }
            //    else
            //    {
            //        Console.WriteLine("");
            //    }
            //}

            #endregion

            #region Q8

            //Console.WriteLine("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            #endregion

            #region Q9

            //Console.WriteLine("Enter the base Numb1: ");
            //int Num1= int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Numb2: ");
            //int Num2 = int.Parse(Console.ReadLine());

            //double result = Math.Pow(Num1 , Num2);


            //Console.WriteLine($"{Num1}^{Num2} = {result}");



            #endregion

            #region Q10

            //Console.WriteLine("Enter marks for subject 1: ");
            //int subject1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter marks for subject 2: ");
            //int subject2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter marks for subject 3: ");
            //int subject3 = int.Parse(Console.ReadLine());

            //int totalMarks = subject1 + subject2 + subject3;

            //double averageMarks = totalMarks / 3 ;

            //double percentage = (totalMarks / 300) * 100 ;

            //Console.WriteLine($"total Marks = {totalMarks}");
            //Console.WriteLine($"average Marks = {averageMarks}");
            //Console.WriteLine($"percentage = {percentage}");


            #endregion

            #region Q11

            //Console.WriteLine("Enter the month number : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //int daysInMonth;


            //if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 || monthNumber == 8 || monthNumber == 10 || monthNumber == 12)
            //{
            //    daysInMonth = 31;
            //}
            //else if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
            //{
            //    daysInMonth = 30;
            //}
            //else if (monthNumber == 2)
            //{
            //    daysInMonth = 28;  
            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number.");
            //    return;
            //}


            //Console.WriteLine($"Days in Month: {daysInMonth}");

            #endregion

            #region Q12

            //Console.WriteLine("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Select an operation:");
            //Console.WriteLine("1. Add");
            //Console.WriteLine("2. Divided");

            //int choice = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter operation (1-2): ");

            //if (choice == 5)
            //{
            //    Console.WriteLine($"Result: {num1 + num2}");
            //}
            //else if (choice == 10)
            //{
            //    Console.WriteLine($"Result: {num1 / num2}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice");
            //}
            //  //zero
            //if (num2 != 0)
            //{
            //    Console.WriteLine($"Result: {num1 / num2}");
            //}
            //else
            //{
            //    Console.WriteLine(" sorry Cannot divide by zero.");
            //}


            #endregion

            #region Q13

            ////?/????

            #endregion

            #region Q14
            ///????
            #endregion

            #region Q15

            //Console.WriteLine("starting number of range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("ending number of range: ");
            //int End = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The prime numbers between {start} and {End} are:");

            //for (int number = start; number <= End; number++)
            //{
            //    if (number == 1)
            //        continue; 

            //    bool isPrime = true;
            //    for (int i = 2; i <= number / 2; i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.WriteLine(number + "  prime number");
            //    }
            //}

            #endregion

            #region Q16
            //Console.WriteLine("Enter a number to convert: ");
            //int decimalNumber = int.Parse(Console.ReadLine());

            //string Binary = Convert.ToString(decimalNumber,2);
            //Console.WriteLine($"the Binary of {decimalNumber} is {Binary} ");

            #endregion

            #region Q17

            ///???????

            #endregion

            #region Q18

            //Console.WriteLine("Enter the time taken to complete the task: ");
            //double timeTaken = double.Parse(Console.ReadLine());

            //if (timeTaken >= 2 && timeTaken <= 3) //in hours
            //{
            //    Console.WriteLine("The worker is highly efficient.");
            //}
            //else if (timeTaken > 3 && timeTaken <= 4)
            //{
            //    Console.WriteLine("The worker needs to increase their speed.");
            //}
            //else if (timeTaken > 4 && timeTaken <= 5)
            //{
            //    Console.WriteLine("The worker will be provided with training to enhance their speed.");
            //}
            //else if (timeTaken > 5)
            //{
            //    Console.WriteLine("The worker is required to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive number for time.");
            //}


            #endregion

            #region Q19


            //Console.WriteLine("Enter the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 0; i < n; i++) //is it row?
            //{
            //    for (int j = 0; j < n; j++) // is it coulmn?
            //    {

            //        if (i == j)
            //        {
            //            Console.WriteLine(" 1 ");
            //        }
            //        else
            //        {
            //            Console.WriteLine(" 0 ");
            //        }
            //    }
            //}


            #endregion

            #region Q20

            //Console.WriteLine("Enter the size of the array: ");
            //int sizeOfArray = int.Parse(Console.ReadLine());

            //int[] numbers = new int[sizeOfArray];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < sizeOfArray; i++)
            //{
            //    Console.WriteLine($"Element {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}


            //int sum = 0;
            //for (int i = 0; i < sizeOfArray; i++)
            //{
            //    sum += numbers[i];  
            //}


            //Console.WriteLine($"The sum of all elements in the array is: {sum}");

            #endregion

            #region Q21

            /////???

            #endregion

            #region Q22


            //Console.WriteLine("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());


            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //// wba3denn?/??

            #endregion

            #region Q23

            //Console.Write("Enter the size of the array: ");
            //int Arraysize = int.Parse(Console.ReadLine());


            //int[] array = new int[Arraysize];


            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < Arraysize; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}


            //int maxElement = array[0];
            //int minElememt = array[0];


            //for (int i = 1; i < Arraysize; i++)
            //{
            //    if (array[i] > maxElement)
            //    {
            //        maxElement = array[i]; 
            //    }
            //    if (array[i] < minElememt)
            //    {
            //        minElememt = array[i]; 
            //    }
            //}


            //Console.WriteLine($"The maximum element in the array is: {maxElement}");
            //Console.WriteLine($"The minimum element in the array is: {minElememt}");



            #endregion

            #region Q24

            ////???
            #endregion

            #region Q25

            //????


            #endregion

            #region Q26

            //hwa f eh??! ana msh 3arf a7l!

            #endregion

            #region Q27


            //Console.WriteLine("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the number of columns: ");
            //int cols = int.Parse(Console.ReadLine());


            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];


            //Console.WriteLine("Enter the values for the first array row by row:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.WriteLine($"Enter value for firstArray[{i}][{j}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}


            //Console.WriteLine("Second array :");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();

            #endregion

            #region Q28


            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());


            int[] array = new int[size];


            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nArray in reverse order:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");

                #endregion
            }
        }
        }
    }


