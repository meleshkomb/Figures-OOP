using FigureTask.Interfaces;
using System;

namespace FigureTask.Entities
{
    /// <summary>
    /// Figure "Circle"
    /// </summary>
    public class Circle : IGetSquare
    {
        /// <summary>
        /// Circle radius, by millimeters
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="radius">Circle radius, by millimeters</param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Input value must be greater than zero.");
            }

            Radius = radius;
        }

        /// <summary>
        /// Get square of current circle
        /// </summary>
        /// <returns>Value, by square millimeters</returns>
        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
