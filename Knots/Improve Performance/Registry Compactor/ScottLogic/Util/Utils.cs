﻿using System;
using System.Windows;

namespace ScottLogic.Util
{
	/// <summary>
	/// Utils used in the ScottLogic PieChart
	/// </summary>
    public static class Utils
    {
		/// <summary>
		/// The <see cref="ScottLogic.Util"/> namespace defines utils used in the ScottLogic PieChart
		/// </summary>

        /// <summary>
        /// Converts a coordinate from the polar coordinate system to the cartesian coordinate system.
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static Point ComputeCartesianCoordinate(double angle, double radius)
        {
            // convert to radians
            double angleRad = (Math.PI / 180.0) * (angle - 90);

            double x = radius * Math.Cos(angleRad);
            double y = radius * Math.Sin(angleRad);

            return new Point(x, y);
        }
    }
}
