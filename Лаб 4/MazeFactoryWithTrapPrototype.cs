using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;
using Лаб_1;

namespace Лаб_4
{
    internal class MazeFactoryWithTrapPrototype : MazeFactoryPrototype
    {

        protected MazeFactoryWithTrapPrototype()
            : base(new Maze(), new Wall(), new RoomWithTrap(), new DoorWithTrap())
        {
        }
    }
}
