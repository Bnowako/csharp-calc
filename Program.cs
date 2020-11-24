using System;

namespace calc
{
    static class Globals
    {
        public static float Result = 0;
        public static bool RunCalc = true;
        public static string CalcMenu = "ce";
        public static bool SkipIteration = false;
    }
    class Program
    {
        static void Main(string[] args)
        {

            ArithmeticLogic arithmeticLogic = new ArithmeticLogic();


            Console.WriteLine("Calc Menu:");
            Console.WriteLine("     c - reset result");
            Console.WriteLine("     e - exit calculator");
            Console.WriteLine("\nYou can use menu all the times");
            Console.WriteLine("After firs operation, default first number is result\n");

            Globals.Result = GetNumberInput();


            while (Globals.RunCalc)
            {
                if (Globals.SkipIteration)
                {
                    Globals.SkipIteration = false;
                    Globals.Result = GetNumberInput();


                    if (!Globals.RunCalc)
                    {
                        break;
                    }
                    else if (Globals.SkipIteration)
                    {
                        continue;
                    }

                }

                string operatorSign = GetOperatorInput();

                if (!Globals.RunCalc)
                {
                    break;
                }
                else if (Globals.SkipIteration)
                {
                    continue;
                }


                float secondNumber = GetNumberInput();
                if (!Globals.RunCalc)
                {
                    break;
                }
                else if (Globals.SkipIteration)
                {
                    continue;
                }


                Globals.Result = arithmeticLogic.CalculateOperation(Globals.Result, operatorSign, secondNumber);

                Console.WriteLine("result is: {0}", Globals.Result);
            }

        }


        static string GetOperatorInput()
        {
            bool isOperator = false;
            string userInput = "+";
            while (!isOperator)
            {
                Console.Write("Enter Operator * / + - % ");

                userInput = GetUserInput();
                if (userInput != "" && Globals.CalcMenu.Contains(userInput))
                {
                    break;
                }
                isOperator = IsStringOperator(userInput);
            }

            return userInput;
        }

        static bool IsStringOperator(string operatorSign)
        {
            bool isOperator = false;
            string operatorSigns = "+-/*%";
            if (operatorSign.Length == 1 && operatorSigns.Contains(operatorSign))
            {
                isOperator = true;

            }
            else
            {
                isOperator = false;
            }


            return isOperator;
        }

        static float GetNumberInput()
        {
            bool validAnswer = false;
            float result = 0;

            while (!validAnswer)
            {

                Console.Write("Enter Number: ");

                string userInputNumber = GetUserInput();
                if (userInputNumber != "" && Globals.CalcMenu.Contains(userInputNumber))
                {
                    break;
                }
                (validAnswer, result) = IsStringNumber(userInputNumber);
            }
            return result;
        }

        static (bool, float) IsStringNumber(string inputNumber)
        {

            bool isNumber = float.TryParse(inputNumber, out float result);

            return (isNumber, result);

        }

        static string GetUserInput()
        {
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "c" || userInput.ToLower() == "e"){
                HandleCalcMenu(userInput);
            }


            return userInput;
        }

        static void HandleCalcMenu(string userInput)
        {
            if (userInput.ToLower() == "c")
            {
                Globals.Result = 0;
                Globals.SkipIteration = true;
                Console.WriteLine("result is: {0}", Globals.Result);

            }
            else if (userInput.ToLower() == "e")
            {
                Globals.RunCalc = false;
            }
        }
    }


}
 