using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;
using Лаб_1;

namespace Лаб_5
{
    class MazeWithTrapSingleton : MazeWithTrapFactory
    {
        private static MazeWithTrapSingleton _instance;

        private MazeWithTrapSingleton()
        { }

        public static MazeWithTrapSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeWithTrapSingleton();
            }
            return _instance;
        }
    }
}
