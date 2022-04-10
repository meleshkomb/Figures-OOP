namespace FigureTask.Formulas
{
    public static class Theoremas
    {
        /// <summary>
        /// Use Pythagoras's Theorema
        /// TODO: Checking values for Hypotenuses
        /// </summary>
        /// <param name="a">Cathetus</param>
        /// <param name="b">Cathetus</param>
        /// <param name="c">Hypotenuses</param>
        /// <returns>
        /// If result is "1", then triangular - obtuse-angular.
        /// If result is "0", then tr. - rectangular.
        /// If result is "-1", then triangular - acute-angular.
        /// </returns>
        public static int CheckTriangleByPythagoras(double a, double b, double c)
        {
            double sqrA = a * a;
            double sqrB = b * b;
            double sqrC = c * c;

            //TODO: Add treshold error
            if (sqrC == (sqrA + sqrB))
            {
                return 0;
            }
            else
            {
                if (sqrC > (sqrA + sqrB))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

    }
}
