using System;

namespace birkelime_birislem
{
    class Operation
    {
        public string OperationSteps { get; set; }
        public int OperationID { get; set; }
        public int ResultFound { get; set; }



        public int MathOperation(int operationType, int number1, int number2)
        {

            if (operationType == 0)
            {
                OperationSteps += (number1.ToString() + " + " + number2.ToString() + " = " + (number1 + number2).ToString());
                OperationSteps += Environment.NewLine;
                return number1 + number2;
            }
            if (operationType == 1)
            {
                if (number1 - number2 < 0 || number1 == number2)
                    return -1;
                OperationSteps += (number1.ToString() + " - " + number2.ToString() + " = " + (number1 - number2).ToString());
                OperationSteps += Environment.NewLine;
                return number1 - number2;
            }
            if (operationType == 2)
            {
                OperationSteps += (number1.ToString() + " * " + number2.ToString() + " = " + (number1 * number2).ToString());
                OperationSteps += Environment.NewLine;
                return number1 * number2;
            }
            if (operationType == 3)
            {
                if (number2 == 0 || number1 % number2 != 0)
                    return -1;

                if (number2 != 0)
                {
                    OperationSteps += (number1.ToString() + " / " + number2.ToString() + " = " + (number1 / number2).ToString());
                    OperationSteps += Environment.NewLine;
                    return number1 / number2;
                }
                return 0;
            }
            return 0;

        }


    }
}
