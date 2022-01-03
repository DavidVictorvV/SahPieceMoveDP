using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorWithCommand
{
    class PieceFlow
    {
        private readonly Piece _piece;
        private PieceCommand _lastCommand;

        private readonly List<PieceCommand> _commandHistory = new List<PieceCommand>();

        public PieceFlow(Piece piece)
        {
            _piece = piece;
        }

        public void ExecuteOperation(Operation operation)
        {
            var calcCommand = new PieceCommand(_piece, operation);
            calcCommand.Execute();
            _commandHistory.Add(calcCommand);
        }

        public void Undo()
        {
            var lastCommand = _commandHistory.LastOrDefault();
            if (lastCommand == null) return;
            _lastCommand = lastCommand;
            lastCommand.UnExecute();
            _commandHistory.Remove(lastCommand);
        }

        public void Redo()
        {
            var lastCommand = _lastCommand;
            lastCommand?.Execute();
        }
    }
}
