using System;
using System.Collections.Generic;
using PaintPalleteProxy.Utils;

namespace PaintPalleteProxy
{
    /// <summary>
    /// database simulation
    /// </summary>
    public class StorePaint
    {
        private Dictionary<string, Paint> _paints;
        public StorePaint()
        {
            _paints = new Dictionary<string, Paint>();
            foreach (string color in Enum.GetNames(typeof(ConsoleColor)))
            {
                _paints.Add(color, new Paint(color));
            }
        }
        
        public Paint GetPaint(string color)
        {
            color = color.CapitalFirstLetter();
            if (!_paints.ContainsKey(color))
            {
                throw new UnknownColorException(color);
            }
            return _paints[color];
        }
    }
}