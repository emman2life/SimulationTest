using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationTest
{
   public interface ISimulationTable
    {
        public string Simulate(string str);


        public bool IsFailed(TableObject tableObject);
        public TableCell[][] getTable();
    }

   
 
}
