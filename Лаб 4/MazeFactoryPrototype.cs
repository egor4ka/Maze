﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;
using Лаб_1;

namespace Лаб_4
{
    internal class MazeFactoryPrototype : MazeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Door _prototypeDoor;
        private Wall _prototypeWall;

        protected MazeFactoryPrototype(Maze maze, Wall wall, Room room, Door door)
        {
            _prototypeDoor = door;
            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
        }

        public MazeFactoryPrototype()
            : this(new Maze(), new Wall(), new Room(), new Door())
        {
        }

        public override Maze CreateMaze()
        {
            return _prototypeMaze.Clone();
        }
        public override Room CreateRoom(int roomNumber)
        {
            Room room = _prototypeRoom.Clone();
            if (roomNumber <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            room.Initialize(roomNumber);
            return room;
        }
        public override Wall CreateWall()
        {
            Wall wall = _prototypeWall.Clone();
            return wall;
        }
        public override Door CreateDoor(Room room1, Room room2)
        {
            Door door = _prototypeDoor.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}
