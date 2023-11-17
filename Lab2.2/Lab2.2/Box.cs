using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    class Box
    {
        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box

        private int X { get; set; }
        private int Y { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }
        private char symbol;
        private char Symbol
        {
            get
            {
                return (char)symbol;
            }
            set
            {
                if (value == '*' || value == '+' || value == '.') symbol = (char)value;
                else symbol = '*';
            }
        }
        private int volume;
        private string message;

        public Box()
        {
            X = 0;
            Y = 0;
            Width = 0;
            Height = 0;
            Symbol = '*';
            volume = 0;
            message = new string("");
        }

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message

        public void Draw(string message, int x = 0, int y = 0, int width = 3, int height = 3, char symbol = '*')
        {
            this.message = message;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            Symbol = symbol;
            if (width > 2 && height > 2) volume = (width - 2) * (height - 2);
            else volume = 0;
            draw();
        }

        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary

        private void draw()
        {
            int i = 0;
            if(volume < message.Length && message.Length > 4 && volume > 2) //Trim message if it's too long
            {
                message = message.Substring(0, volume - 2);
                message += "..";
            }
            for (int h = 0; h < Height; h++)
            {
                Console.SetCursorPosition(X, Y + h);
                if (h == 0 || h == Height - 1) //First and last line
                {
                    for (int w = 0; w < Width; w++)
                    {
                        Console.Write(symbol);
                    }
                }
                else
                {
                    Console.Write(symbol);
                    for(int j = 0; j < Width - 2; j++)
                    {
                        if(i < message.Length)
                        {
                            Console.Write(message[i]);
                            i++;
                        }
                        else Console.Write(" "); 
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
