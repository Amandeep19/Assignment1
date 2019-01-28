using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Amandeep
{
    public class Rectangle
    {
        private int length;
        private int width;
        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }
        public Rectangle() 
        {
            Length = 1;
            Width = 1;
        }
        public Rectangle(int l, int w) 
        {
            Length = l;
            Width = w;
        }

        public int GetLength() 
        {
            return Length;
        }

        public int SetLength(int l) 
        {
            Length = l;
            return Length;
        }
        public int GetWidth() 
        {
            return Width;
        }

        public int SetWidth(int w) 
        {
            Width = w;
            return Width;
        }

        public int GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public int GetArea() 
        {
            return Length * Width;
        }
    }
}
