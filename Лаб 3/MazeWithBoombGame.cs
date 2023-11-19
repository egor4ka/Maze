﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;

namespace Лаб_3
{
    public class MazeWithBoombGame : MazeGame
    {
        protected override Room CreateRoom(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Номер комнаты не соответствует условию");
            }
            return new RoomWithBoomb(number);
        }

        protected override Wall CreateWall()
        {
            return new WallWithBoomb();
        }
    }
}
