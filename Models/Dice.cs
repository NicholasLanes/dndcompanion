using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnd.Models
{
    public class Dice
    {
        // This will set the range for the D6 dice from the lowest it can be and the highest so when we randomize it it stays within range
        //public int sixSidedDiceLowestNumber { get; set; } = 1;
        //public int sixSidedDiceHighestNumber { get; set; } = 6;
        //// This will be for D8 dice from the lowest to highest in a range
        //public int eightSidedDiceLowestNumber { get; set; } = 1;
        //public int eightSidedDiceHighestNumber { get; set; } = 8;
        //// This will be for the D10 dice and give a range from lowest to highest.
        //public int tenSidedDiceLowestNumber { get; set; } = 1;
        //public int tenSidedDiceHighestNumber { get; set; } = 10;
        //// This will be the range for the D12 dice from lowest to highest.
        //public int twelveSidedDiceLowestNumber { get; set; } = 1;
        //public int twelveSidedDiceHighestNumber { get; set; } = 12;
        //// This will be thr rangr for a D20 dice from lowest to highest.
        //public int twentySidedDiceLowestNumber { get; set; } = 1;
        //public int twentySidedDiceHighestNumber { get; set; } = 20;
        public int rollResult { get; set; }
        public int RollCount { get; set; }
        //public int GetDiceRoll()
        //{
        //    Random r = new Random();
        //    rollResult = r.Next(1, 12);
        //    return rollResult;
        //}
       
    }
}
