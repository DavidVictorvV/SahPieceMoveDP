using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithCommand
{
    class PieceCommand : Command
    {
        private Operation _operation;
        private Piece _piece;

        public PieceCommand(Piece piece, Operation operation)
        {
            _piece = piece;
            _operation = operation;
        }

        public override void Execute()
        {
            _piece.Calculate(_operation);
        }

        public override void UnExecute()
        {
            _piece.Calculate(UndoOperation(_operation));
        }

        private Operation UndoOperation(Operation operation)
        {
            switch (operation)
            {
                case Operation.Up:
                    return Operation.Down;
                case Operation.Down:
                    return Operation.Up;
                case Operation.Right:
                    return Operation.Left;
                case Operation.Left:
                    return Operation.Right;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }
    }
}
