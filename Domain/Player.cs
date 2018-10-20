using System;

namespace Domain
{
    public class Player
    {
        public string Name { get; set; }
        public int TableDimension;
        public string[,] ownShipsTable;
        public string[,] opponentShipsTable;

        public Player(string name, int tableDimension)
        {
            TableDimension = tableDimension;
            Name = name;
            
            ownShipsTable = new String[TableDimension,TableDimension];
            opponentShipsTable = new String[TableDimension, TableDimension];
        
            Console.WriteLine(Name);

            for (int i = 0; i < TableDimension; i++) {
                for (int j = 0; j < TableDimension; j++)
                {
                    ownShipsTable[i, j] = "0";
                    Console.Write(ownShipsTable[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            
            
            for (int i = 0; i < TableDimension; i++) {
                for (int j = 0; j < TableDimension; j++)
                {
                    opponentShipsTable[i, j] = "0";
                    Console.Write(opponentShipsTable[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public override string ToString()
        {
            return Name;
        }
    }
    
    
}