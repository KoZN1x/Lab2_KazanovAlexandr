using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_KazanovAlexandr
{
    internal class StringTasks
    {
        public void FirstTask (string taskName) 
        {
            string[] blocks = taskName.Split ('-');
            foreach (var block in blocks)
            {
                int index = 0;
                for (int i = 0; i < block.Length; i++)
                {
                    if (Char.IsDigit(block[i]))
                    {
                        index++;
                    }
                    if (index == block.Length)
                    {
                        Console.Write(block);
                    }
                }
            }
        }

        public void SecondTask(string taskName)
        {
            string[] blocks = taskName.Split('-');
            for (int i = 0; i < blocks.Length; i++)
            {
                int index = 0;
                for (int j = 0; j < blocks[i].Length; j++)
                {
                    if (Char.IsLetter(blocks[i][j]))
                    {
                        index++;
                    }
                    if (index == blocks[i].Length)
                    {
                        blocks[i] = "***";
                    }
                }
            }
            taskName = string.Join('-', blocks);
            Console.WriteLine(taskName);
        }

        public void ThirdTask(string taskName)
        {
            
        }
    }
}
