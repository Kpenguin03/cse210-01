// See https://aka.ms/new-console-template for more information

using System;

namespace Krisst
{
    class Program
    {
        static void Main(string[] args)
        {

            
            static void DisplayBoard(string[] board)

            {   
                int[] board = {1, 2, 3, 4, 5, 6, 7, 8, 9,};

                Console.WriteLine();
                Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
                Console.WriteLine("Player 1 place x on the board 1-9 ");
                string x = Console.ReadLine();
                board[0] = Console.WriteLine(x);

                //I wrote enough to test, but the actual assignment was to use a virtual control system so I want to focus more on that instead. 


            }
        }

    

        
    }       
}


