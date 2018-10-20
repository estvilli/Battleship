/*using System;
using DAL;
using Domain;

namespace ConsoleApp
{
    public static class DbInitializer
    {
        public static string Name1;
        public static string Name2;
        
        private static int tableDimension;
        public static void Initialize(this DbContext dbContext, int tableDimension, Player player1, Player player2)
        {
            tableDimension = tableDimension;
            Name1 = player1.ToString();
            Name2 = player2.ToString();
            
            string[,] player1ownShipsTable = new String[tableDimension,tableDimension];
            string[,] player1opponentShipsTable = new String[tableDimension,tableDimension];
            
            for (int i = 0; i < tableDimension; i++) {
                for (int j = 0; j < tableDimension; j++)
                {
                    ownShipsTable[i, j] = "-";
                    Console.Write(ownShipsTable[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}*/