﻿using System;
using SFML;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace Agar.net
{
    class Cell
    {
        private uint _id;
        Vector2i _position;
        uint _size;
        Color _color;
        string _name;

        public Cell(uint id)
        {
            _id = id;
            _size = 1;

        }

        public void draw(RenderWindow window)
        {
            CircleShape shape = new CircleShape(50);
            shape.FillColor = _color;
            shape.Position = new Vector2f(_position.X - _size, _position.Y - _size);
            shape.Radius = _size;

            window.draw(shape);
        }

        public void setSize(uint size)
        {
            this._size = size;
        }

        public void setPosition(Vector2i position)
        {
            this._position = position;
        }

        public void setColor(Color color)
        {
            this._color = color;
        }

        public void setName(string name)
        {
            this._name = name;
        }

    }
}
