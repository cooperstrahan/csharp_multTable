using System;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multTable = new int[10,10];
            
            int rowLength = multTable.GetLength(0);
            int colLength = multTable.GetLength(1);

            for(int i = 0; i < rowLength; i++){
                for(int j = 0; j < colLength; j++){
                    multTable[i,j] = (i+1)*(j+1);
                    Console.Write(multTable[i,j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
