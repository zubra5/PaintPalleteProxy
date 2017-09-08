using System;
using System.Runtime.Serialization;

namespace PaintPalleteProxy
{
    [Serializable]
    public class UnknownColorException : Exception
    {
        public UnknownColorException(string color):base($"No paint with color ={color}")
        {
           
        }
    }
}