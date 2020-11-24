using System;
namespace calc
{
    public class ArithmeticLogic
    {
        

        public float CalculateOperation(float firstNumber, string operationSign, float secondNumber)
        {
            float result = 0;

            switch (operationSign)
            {
                case "+":
                    result = CalculateAddition(firstNumber, secondNumber);
                    break;
                case "-":
                    result = CalculateSubtraction(firstNumber, secondNumber);
                    break;
                case "*":
                    result = CalculateMultiplication(firstNumber, secondNumber);
                    break;
                case "/":
                    result = CalculateDivision(firstNumber, secondNumber);
                    break;
                case "%":
                    result = CalculateModulo(firstNumber, secondNumber);
                    break;
            }

            return result;
        }
        public float CalculateAddition(float firstNumber, float secondNumber)
        {
            float result = firstNumber + secondNumber;
            return result;
        }
        public float CalculateSubtraction(float firstNumber, float secondNumber)
        {
            float result = firstNumber - secondNumber;
            return result;
        }
        public float CalculateMultiplication(float firstNumber, float secondNumber)
        {
            float result = firstNumber * secondNumber;
            return result;
        }
        public float CalculateDivision(float firstNumber, float secondNumber)
        {
            float result = firstNumber / secondNumber;
            return result;
        }
        public float CalculateModulo(float firstNumber, float secondNumber)
        {
            float result = firstNumber % secondNumber;
            return result;
        }




    }
}
