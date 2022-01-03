using System;
using System.Collections.Generic;

namespace CalculatorWithCommand
{
    public class Piece
    {

        private string _position;
        public Piece(string pos)
        {
            _position = pos;
        }
        private readonly List<string> _letterList = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H" };

        public void Calculate(Operation operation)
        {
            int letterPos = _letterList.IndexOf(_position[1].ToString());
            if(letterPos == -1)
            {
                _position = _position[0] + _letterList[0];
                letterPos = 0;
            }
            if(_position[0] - '0' != 8) { 
            switch (operation)
            {
                case Operation.Up: if (_position[0] - '0' < 8) _position = (_position[0] - '0' + 1).ToString() + _position[1]; break;
                case Operation.Down: if (_position[0] - '0' > 1) _position = (_position[0] - '0' - 1).ToString() + _position[1]; break;
                case Operation.Left:  if(letterPos > 0) _position = _position[0] + _letterList[letterPos - 1].ToString(); break;
                case Operation.Right: if (letterPos < _letterList.Count - 1) _position = _position[0] + _letterList[letterPos + 1].ToString(); break;
            }
            Console.WriteLine($"Current value = {_position} (after {operation})");
            }
            else
            {
                Console.WriteLine($"U have arrived at the top value = {_position} and can no longer move");
            }
        }
    }
}
