using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownGame
{
    class OperationManager
    {
       public List<int> FirstNumbers = new List<int>();
       public List<int> AvailableNumbers = new List<int>();
       public List<int> FoundCloseNumbers = new List<int>();
       public Operation operation = new Operation();
       public List<Operation> operationList = new List<Operation>();


        public int NumberToBeFound = 0;
        Random rnd = new Random();
        int counter = 0;
        int currentFoundNumber = 0;
        int selectedNumber = 0;
        int selectedNumber2 = 0;

        private void GenerateRandomNumbers()
        {
            Random rnd = new Random();
            int tempNumber;
            NumberToBeFound = rnd.Next(100, 1000);
            for (int i = 0; i < 6; i++)
            {
                if (i == 5)
                {
                    tempNumber = rnd.Next(10, 100);
                    while(tempNumber%10 != 0)
                    {
                        tempNumber = rnd.Next(10, 100);
                    }
                    FirstNumbers.Add(tempNumber);
                    AvailableNumbers.Add(tempNumber);
                    continue;
                }
                tempNumber = rnd.Next(1, 10);
                FirstNumbers.Add(tempNumber);
                AvailableNumbers.Add(tempNumber);
            }


        }
    
        public Operation MakeOperation()
        {
            GenerateRandomNumbers();
            int selectedMathOperation;
            while (counter!=20000)
            {
                int i1 = rnd.Next(AvailableNumbers.Count);
                int i2= rnd.Next(AvailableNumbers.Count);

                selectedNumber = AvailableNumbers[i1];
                selectedNumber2 = AvailableNumbers[i2];

                if (i1 == i2 && AvailableNumbers.Count>1)
                    continue;

                selectedMathOperation = rnd.Next(0, 4);

                currentFoundNumber = operation.MathOperation(selectedMathOperation, selectedNumber, selectedNumber2);

                if (currentFoundNumber == -1)
                    continue;

                AvailableNumbers.Remove(selectedNumber);
                AvailableNumbers.Remove(selectedNumber2);
                AvailableNumbers.Add(currentFoundNumber);

               
                if (Math.Abs(currentFoundNumber - NumberToBeFound) < 9)
                {
                    FoundCloseNumbers.Add(currentFoundNumber);
                    operation.ResultFound = currentFoundNumber;
                    operationList.Add(operation);
                    Reset();
                }
                
            
                if (counter % 20 == 0 || AvailableNumbers.Count<=1)
                    Reset();
                counter += 1;
            }
            int closest = FoundCloseNumbers.Aggregate((x, y) => Math.Abs(x - NumberToBeFound) < Math.Abs(y - NumberToBeFound) ? x : y);

            Operation closestOperation = new Operation();
            foreach (var item in operationList)
            {
                if (item.ResultFound == closest)
                    closestOperation = item;

            }
           return closestOperation;

        }
        private void Reset()
        {
            operation = new Operation();
            AvailableNumbers.Clear();
            foreach (var item in FirstNumbers)
            {
                AvailableNumbers.Add(item);
            }
        }
    }
}
