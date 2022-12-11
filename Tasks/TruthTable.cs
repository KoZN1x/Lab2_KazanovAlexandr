using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_KazanovAlexandr.Tasks
{
    internal class TruthTable
    {
        public static void HardTask()
        {
            Console.WriteLine("Please, input number of your operands.");
            int length = int.Parse(Console.ReadLine());
            StringBuilder tableHeader = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                tableHeader.Append($"X{i + 1}     ");
            }
            Console.WriteLine("Please, input your operation.");
            string operation = Console.ReadLine().ToUpper();
            tableHeader.Append(operation);
            Console.WriteLine("Result: \n" + tableHeader);

            //int rows = length ^ 2 - length + 2;
            //int columns = length + 1;
            //string[,] truthTable = new string[rows, columns];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    { 
                    
            //    }
            //}
            
        }
    }
}
