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
            
        }
        public override string ToString()
        {
            return Name;
        }
    }
    
    
}