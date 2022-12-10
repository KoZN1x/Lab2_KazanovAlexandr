using System;

namespace Lab2_KazanovAlexandr
{
    internal class Scanner
    {
        public static void FourthTask(int[] array)
        {
            Console.WriteLine("Please enter your scanner number!");
            bool IsNumberInTheArray = false;
            int scanner = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (scanner == array[i])
                {
                    IsNumberInTheArray = true;
                    break;
                }
            }
            if (IsNumberInTheArray) Console.WriteLine("Entered value is in the array.");
            else Console.WriteLine("Entered value isn't in the array.");
        }
    }
    internal class CyclesTasks
    {
        static void Main(string[] args)
        {
            var array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //FirstTask();
            //SecondTask();
            //ThirdTask();
            //Scanner.FourthTask(array);
            //FifthTask();
            //SixthTask();
            //SeventhTask();
            //EighthTask();
            //NinthTask();
            string stringTask = "1234-abc-1234-ABC-1a2b";
            StringTasks stringTasks = new StringTasks();
            //stringTasks.FirstTask(stringTask);
            //stringTasks.SecondTask(stringTask);
            //stringTasks.ThirdTask(stringTask);
            //stringTasks.FourthTask(stringTask);
            //stringTasks.FifthTask(stringTask);
            //stringTasks.SixthTask(stringTask);
            //stringTasks.SeventhTask(stringTask);
            
        }

        static void FirstTask()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void SecondTask()
        {
            int number = 5;
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        static void ThirdTask()
        {
            Console.WriteLine("Please, input your number!");
            int imputNumber = int.Parse(Console.ReadLine());
            int summ = 0;
            for (int i = 1; i < imputNumber; i++)
            {
                summ += i;
            }
            Console.WriteLine(summ);
        }

        static void FifthTask()
        {
            double summOfValues = 0;
            int maxValue;
            int minValue;
            Console.WriteLine("Please enter the length of the array.");
            int length = int.Parse(Console.ReadLine());
            var array = new int[length];
            var rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                summOfValues += array[i];
            }
            Console.WriteLine($"Average value is {summOfValues / length:f1}");
            maxValue = minValue = array[0];
            for (int i = 0; i < length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
                else if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine($"Max value is {maxValue}. \nMin value is {minValue}.");
        }

        static void SixthTask()
        {
            var array1 = new int[] { 1, 2, 3, 4, 5 };
            var array2 = new int[] { 5, 4, 3, 2, 1 };
            for (int i = 0; i < array1.Length; i++) 
            {
                Console.Write($"{array1[i]} ");
            }
            Console.Write("\n");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
        }

        static void SeventhTask()
        {
            int[] array = new int[11];
            for (int i = 0; i < array.Length; i++)
            {
                if ( i == 0)
                {
                    array[i] = 0;
                }
                else if (i == 1 || i == 2)
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] = (array[i - 1]) + (array[i - 2]);
                }
                Console.Write($"{array[i]} ");
            }
        }

        static void EighthTask()
        {
            int[] array = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            for (int i = 0; i < array.Length;i++) 
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write("\n");
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) array[i] = 0;
                Console.Write($"{array[i]} ");
            }
        }

        static void NinthTask()
        {
            int result = 0;
            string bubble = "";
            var array = new string[5] { "Alexey", "Miron", "Gleb", "Matvey", "Adam", };
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++) 
                {
                    result = String.Compare(array[j], array[j + 1]);
                    if (result > 0)
                    {
                        bubble = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = bubble;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++) 
            { 
                Console.Write($"{array[i]} "); 
            }
        }
    }
}