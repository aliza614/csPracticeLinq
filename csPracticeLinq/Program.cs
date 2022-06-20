using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfGames = new List<string>();
            listOfGames.Add("Super Mario Brothers");
            listOfGames.Add("Donkey Kong");
            listOfGames.Add("Tetris");

            listOfGames.OrderBy(x => ((string)x).Length).ToList().ForEach(Console.WriteLine);

            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for(int i = 0; i < listOfGames.Count-1; i++)
                {
                    if (listOfGames.ElementAt(i).Length > listOfGames.ElementAt(i + 1).Length)
                    {
                        isSorted = false;
                        String temp=listOfGames.ElementAt(i);
                        listOfGames.RemoveAt(i);
                        listOfGames.Insert(i + 1, temp);

                    }
                }
            }
            foreach (string game in listOfGames)
            {
                Console.WriteLine(game);
            }
            
        }
    }
}
