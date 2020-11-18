using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationTest
{
    class Table : ISimulationTable
    {
        private int _height;
        private int _width;
        private int _objectPositionX;
        private int _objectPositionY;
        private TableObject tableObject;

        public Table(string input)
        {
            int[] numsArray = Array.ConvertAll(input.Split(','), int.Parse);
            _height = numsArray[0];
            _width = numsArray[1];
            _objectPositionX = numsArray[2];
            _objectPositionY = numsArray[3];
        }
        public TableCell[][] getTable()
        {
            TableCell[][] table = new TableCell[_height][];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new TableCell[_width];
            }


            return table;
        }
        public string Simulate(string str)
        {
            tableObject = new TableObject(_objectPositionX, _objectPositionY);


            int[] numsArray = Array.ConvertAll(str.Split(','), int.Parse);

            for (int i = 0; i < numsArray.Length; i++)
            {

                switch (numsArray[i])
                {
                    case 0:

                        break;
                    case 1:
                        tableObject.MoveForwardOneStep();
                        break;
                    case 2:
                        tableObject.MoveBackwardOneStep();
                        break;
                    case 3:
                        tableObject.RotateClockwise();
                        break;
                    case 4:
                        tableObject.RotateCounterClockwise();
                        break;


                }
                if (IsFailed(tableObject))
                {
                    return "Object fell of at " + tableObject.ToString();
                }
            }
            return tableObject.ToString();
        }
        public bool IsFailed(TableObject tableObject)
        {

            if (tableObject.PositionX < 0 || tableObject.PositionX >= _height || tableObject.PositionY < 0 || tableObject.PositionY >= _width)
            {
                return true;
            }

            return false;
        }

    }
}
