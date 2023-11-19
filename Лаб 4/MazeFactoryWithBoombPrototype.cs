using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;
using Лаб_1;

namespace Лаб_4
{
    internal class MazeFactoryWithBoombPrototype : MazeFactoryPrototype
    {

        protected MazeFactoryWithBoombPrototype()
             : base(new Maze(), new WallWithBoomb(), new RoomWithBoomb(), new Door())
        {
        }

    }
}

