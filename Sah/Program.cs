using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorWithCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Piece("1G");
            var calcFlow = new CalculatorFlow(calculator);
            calcFlow.ExecuteOperation(Operation.Up);//2G
            calcFlow.ExecuteOperation(Operation.Up);//3G
            calcFlow.ExecuteOperation(Operation.Up);//4G
            calcFlow.ExecuteOperation(Operation.Left);//4F
            calcFlow.ExecuteOperation(Operation.Up);//5F
            calcFlow.ExecuteOperation(Operation.Right);//5G
            calcFlow.ExecuteOperation(Operation.Right);//5H
            calcFlow.ExecuteOperation(Operation.Up);//6H


            calcFlow.Undo();//5H
            calcFlow.Redo();//6H

            calcFlow.ExecuteOperation(Operation.Up);//7H

            calcFlow.Undo();//6H
            calcFlow.Redo();//7H

            calcFlow.ExecuteOperation(Operation.Up);//8H

            calcFlow.Undo();//8H
            calcFlow.Redo();//8H

            calcFlow.ExecuteOperation(Operation.Down);//8H


            Console.ReadLine();
        }
    }
}
