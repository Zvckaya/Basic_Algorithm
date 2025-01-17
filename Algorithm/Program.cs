﻿using System;

 namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';

            int lastTick = 0;

            while (true)
            {
                #region 프레임 관리
                int currentTick = System.Environment.TickCount;
                // 경과시간이 1/30초보다 작으면 
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                lastTick = currentTick;
                #endregion 


                Console.SetCursorPosition(0, 0); //커서 포인터 설정
                for(int i = 0; i < 25; i++)
                {
                    for(int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}