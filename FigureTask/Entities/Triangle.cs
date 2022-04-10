using FigureTask.Formulas;
using FigureTask.Interfaces;
using System;

namespace FigureTask.Entities
{
    public class Triangle : IGetSquare
    {
        /// <summary>
        /// Cathetus
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Cathetus
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// Hypotenuses
        /// </summary>
        public double C { get; set; }
        /// <summary>
        /// Current value of HalfPerimeter
        /// </summary>
        private double HalfPerimeter { get; set; }
        /// <summary>
        /// Is Triangle Rectangular
        /// </summary>
        public bool IsRectangular { get; set; }

        /// <summary>
        /// Default constructor for triangle
        /// </summary>
        /// <param name="a">Cathetus</param>
        /// <param name="b">Cathetus</param>
        /// <param name="c">Hypotenuses</param>
        public Triangle(double a, double b, double c)
        {
            //TODO: Check input parameters
            A = a;
            B = b;
            C = c;

            SetRectangularity();
            SetHalfPerimeter();
        }

        /// <summary>
        /// Constructor for rectangular triangle
        /// </summary>
        /// <param name="a">Cathetus</param>
        /// <param name="b">Cathetus</param>
        public Triangle(double a, double b)
        {
            A = a;
            B = b;
            C = Math.Sqrt(A * A + B * B);

            IsRectangular = true;
        }

        private void SetHalfPerimeter()
        {
            HalfPerimeter = (A + B + C) / 2;
        }

        private void SetRectangularity()
        {
            IsRectangular = (0 == Theoremas.CheckTriangleByPythagoras(A, B, C));
        }

        /// <summary>
        /// Get square of current triangle
        /// </summary>
        /// <returns>Value, by square millimeters</returns>
        public double GetSquare()
        {
            if (IsRectangular)
            {
                return (1 / 2) * (A * B);
            }
            else
            {
                return Math.Sqrt(HalfPerimeter * (HalfPerimeter - A) * (HalfPerimeter - B) * (HalfPerimeter - C));
            }
        }
    }
}
