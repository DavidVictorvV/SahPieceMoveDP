using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorWithCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var piece = new Piece("1G");
            var pieceFlow = new PieceFlow(piece);
            pieceFlow.ExecuteOperation(Operation.Up);//2G
            pieceFlow.ExecuteOperation(Operation.Up);//3G
            pieceFlow.ExecuteOperation(Operation.Up);//4G
            pieceFlow.ExecuteOperation(Operation.Left);//4F
            pieceFlow.ExecuteOperation(Operation.Up);//5F
            pieceFlow.ExecuteOperation(Operation.Right);//5G
            pieceFlow.ExecuteOperation(Operation.Right);//5H
            pieceFlow.ExecuteOperation(Operation.Up);//6H


            pieceFlow.Undo();//5H
            pieceFlow.Redo();//6H

            pieceFlow.ExecuteOperation(Operation.Up);//7H

            pieceFlow.Undo();//6H
            pieceFlow.Redo();//7H

            pieceFlow.ExecuteOperation(Operation.Up);//8H

            pieceFlow.Undo();//8H
            pieceFlow.Redo();//8H

            pieceFlow.ExecuteOperation(Operation.Down);//8H


            Console.ReadLine();
        }
    }
}
