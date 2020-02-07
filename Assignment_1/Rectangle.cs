using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class Rectangle
    {
        private int lengthOfRectangle;
        private int widthOfRectangle;

        //default constructor
        public Rectangle()
        {
            lengthOfRectangle = 1;
            widthOfRectangle = 1;
        }

        //non-default constructor
        public Rectangle(int rectangleLength, int rectangleWidth)
        {
            this.lengthOfRectangle = rectangleLength;
            this.widthOfRectangle = rectangleWidth;
        }

        //methods
        public int GetLength()
        {
            return this.lengthOfRectangle;
        }

        public int SetLength(int lengthOfRectangle)
        {
            this.lengthOfRectangle = lengthOfRectangle;
            return this.lengthOfRectangle;
        }

        public int GetWidth()
        {
            return this.widthOfRectangle;
        }

        public int SetWidth(int widthOfRectangle)
        {
            this.widthOfRectangle = widthOfRectangle;
            return this.widthOfRectangle;
        }

        public int GetPerimeter()
        {
            return 2 * (lengthOfRectangle + widthOfRectangle);
        }

        public int GetArea()
        {
            return lengthOfRectangle * widthOfRectangle;
        }

    }
}
