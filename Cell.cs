using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationTest
{
    public abstract class Cell
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }



        public Cell(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;

        }
    }
}
