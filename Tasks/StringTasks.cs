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
                    if (char.IsDigit(block[i]))
                    {
                        index++;
                    }
                    else break;
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
                    if (char.IsLetter(blocks[i][j]))
                    {
                        index++;
                    }
                    else break;
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
            string finalString = "";
            string[] blocks = taskName.Split('-');
            for (int i = 0; i < blocks.Length; i++)
            {
                int index = 0;
                for (int j = 0; j < blocks[i].Length; j++)
                {
                    if (char.IsLetter(blocks[i][j]))
                    {
                        index++;
                    }
                    if (index == blocks[i].Length)
                    {
                        finalString += blocks[i] + '/';
                    }
                    if ((i == blocks.Length - 1) & (char.IsLetter(blocks[i][j])))
                    {
                        finalString += blocks[i][j] + "/";
                    }
                }
            }
            Console.WriteLine(finalString.Substring(0, finalString.Length - 1));
        }

        public void FourthTask(string taskName)
        {
            StringBuilder finalString = new StringBuilder("Letters: ");
            string[] blocks = taskName.Split('-');
            for (int i = 0; i < blocks.Length; i++)
            {
                int index = 0;
                for (int j = 0; j < blocks[i].Length; j++)
                {
                    if (char.IsLetter(blocks[i][j]))
                    {
                        index++;
                    }
                    if (index == blocks[i].Length)
                    {
                        finalString.Append(blocks[i].ToUpper() + "/");
                    }
                    if ((i == blocks.Length - 1) & (char.IsLetter(blocks[i][j])))
                    {
                        finalString.Append(char.ToUpper(blocks[i][j]) + "/");
                    }
                }
            }
            Console.WriteLine(finalString.Remove(finalString.Length - 1, 1));
        }

        public void FifthTask(string taskName)
        {
            string subString = "abc";
            if ((taskName.IndexOf(subString) >= 0) | ((taskName.IndexOf(subString.ToUpper()) >= 0)))
            {
                Console.WriteLine("The document number contains the sequence.");
            }
            else Console.WriteLine("The document number doesn't contain the sequence.");
        }

        public void SixthTask(string taskName)
        {
            if (taskName.StartsWith("555"))
            {
                Console.WriteLine("The document number starts with \"555\" sequence.");
            }
            else Console.WriteLine("The document number doesn't start with \"555\" sequence.");
        }

        public void SeventhTask(string taskName)
        {
            if (taskName.EndsWith("1a2b"))
            {
                Console.WriteLine("The document number ends with \"1a2b\" sequence.");
            }
            else Console.WriteLine("The document number doesn't end with \"1a2b\" sequence.");
        }
    }
}
