using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;
using Лаб_1;

namespace Лаб_5
{
    public class MazeSingleton : MazeFactory
    {
        private static MazeSingleton _instance;

        private MazeSingleton()
        { }

        public static MazeSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeSingleton();
            }
            return _instance;
        }
    }
}
