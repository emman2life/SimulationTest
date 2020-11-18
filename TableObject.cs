using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationTest
{
   public class TableObject
    {

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Direction Direction { get; set; }


        public TableObject(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
            Direction = Direction.North;

        }
        public void MoveNorth()
        {
            PositionY--;
        }
        public void MoveSouth()
        {
            PositionY++;
        }
        public void MoveEast()
        {
            PositionX++;
        }
        public void MoveWest()
        {
            PositionX--;
        }
        public void MoveForwardOneStep()
        {

            switch (Direction)
            {
                case Direction.North:
                    MoveNorth();
                    break;
                case Direction.East:
                    MoveEast();
                    break;
                case Direction.South:
                    MoveSouth();
                    break;
                case Direction.West:
                    MoveWest();
                    break;

            }
        }
        public void MoveBackwardOneStep()
        {
            switch (Direction)
            {
                case Direction.North:
                    MoveSouth();
                    break;
                case Direction.East:
                    MoveWest();
                    break;
                case Direction.South:
                    MoveNorth();
                    break;
                case Direction.West:
                    MoveEast();
                    break;

            }
        }

        public void RotateClockwise()
        {
            switch (Direction)
            {
                case Direction.North:
                    Direction = Direction.East;
                    break;
                case Direction.East:
                    Direction = Direction.South;
                    break;
                case Direction.South:
                    Direction = Direction.West;
                    break;
                case Direction.West:
                    Direction = Direction.North;
                    break;


            }
        }
        public void RotateCounterClockwise()
        {
            switch (Direction)
            {
                case Direction.North:
                    Direction = Direction.West;
                    break;
                case Direction.West:
                    Direction = Direction.South;
                    break;
                case Direction.South:
                    Direction = Direction.East;
                    break;
                case Direction.East:
                    Direction = Direction.North;
                    break;




            }
        }
        public override string ToString()
        {
            string str = "";
            try
            {
                str = "The objects final position is at [" + PositionX + "," + PositionY + "]";
            }
            catch (Exception)
            {

                throw;
            }

            return str;
        }
    }
}

