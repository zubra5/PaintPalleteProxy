using System;


namespace PaintPalleteProxy
{
    public class Paint
    {
        public ConsoleColor Color { get; set; }

        public Paint(string nameColor)
        {
            ConsoleColor color;
            if (Enum.TryParse<ConsoleColor>(nameColor, out color))
            {
                Color = color;
            }
            else
            {
                throw new UnknownColorException(nameColor);
            }
        }
    }
}