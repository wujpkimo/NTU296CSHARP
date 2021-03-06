﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0504Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int gap = 10;
            int cubeLen = 100;
            int currentHeight = 0;
            int currentWidth = 0;

            int winHeight = 600;
            int winWidth = 800;

            int i = 0;
            int j = 0;
            List<string> list = new List<string>();
            do
            {
                do
                {
                    list.Add((gap + currentHeight).ToString() + "," + (gap * (i + 1) + cubeLen * i).ToString());
                    currentWidth = gap * (i + 1) + cubeLen * (i + 1);
                    Console.WriteLine("[{0}]({1})", list.Count(), list[list.Count() - 1]);
                    i++;
                } while (currentHeight < (winHeight - cubeLen) && currentWidth < (winWidth - cubeLen));
                currentWidth = 0;
                i = 0;
                j++;
                currentHeight = (gap + cubeLen) * j;
            } while (currentHeight < (winHeight - cubeLen) && currentWidth < (winWidth - cubeLen));
            Console.WriteLine("在{0}*{1}總共產生{2}個{3}*{3}方塊", winWidth, winHeight, list.Count(), cubeLen);
        }
    }
}