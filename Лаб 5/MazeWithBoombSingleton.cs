using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;
using Лаб_1;

namespace Лаб_5
{
    class MazeWithBoombSingleton : MazeWithBoombFactory
    {
        private static MazeWithBoombSingleton _instance;

        private MazeWithBoombSingleton()
        { }

        public static MazeWithBoombSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeWithBoombSingleton();
            }
            return _instance;
        }
    }
}
