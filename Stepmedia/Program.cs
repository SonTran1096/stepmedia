using System;
using System.Collections.Generic;

namespace Stepmedia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<int> listArray = new List<int> { 1, 6, 2, 8, 4, 7, 8, 3, 0, 9,
                                                    7, 2, 9, 3, 19, 46, 93, 94, 85, 28,
                                                    74, 75, 4, 8 ,93, 74, 75, 28, 84, 90 };
            List<int> listMax = new List<int> { };
            List<int> listMax2 = new List<int> { };
            List<int> listCenter = new List<int> { };
            List<int> listResult = new List<int> { };

            listArray.Sort();
            listArray.Reverse();

            for(int i = 0; i < listArray.Count; i ++)
            {
                if(i < 10)
                {
                    listMax.Add(listArray[i]);
                }
                else if(i < 20)
                {
                    listMax2.Add(listArray[i]);
                }
                else
                {
                    listCenter.Add(listArray[i]);
                }
                
            }

            listResult.AddRange(listMax);
            listResult.AddRange(listCenter);
            listResult.AddRange(listMax2);

            listResult.ForEach(i => Console.Write("{0}-", i));

            Console.ReadLine();

        }
    }
}
