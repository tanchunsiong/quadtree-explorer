using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadTreeExplorer
{
    class Utilities
    {
        public class Box
        {
            public int x;
            public int y;
            public int width;
            public int height;

            public Box(int x, int y, int width, int height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }
        }

        public const double EARTH_RADIUS = 6378137;
        public const double EARTH_CIRCUM = EARTH_RADIUS * 2.0 * Math.PI;
        public const double EARTH_HALF_CIRC = EARTH_CIRCUM / 2;

        /// <summary>
        /// Returns the bounding box for a grid square represented by
        /// the given quad key
        /// </summary>
        /// <param name="quadString"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="zoomLevel"></param>
        /// <returns></returns>
        public static Box QuadKeyToBox(string quadKey, int x, int y, int zoomLevel)
        {
            char c = quadKey[0];

            int tileSize = 2 << (18 - zoomLevel - 1);

            if (c == '0')
            {
                y = y - tileSize;
            }

            else if (c == '1')
            {
                y = y - tileSize;
                x = x + tileSize;
            }

            else if (c == '3')
            {
                x = x + tileSize;
            }

            if (quadKey.Length > 1)
            {
                return QuadKeyToBox(quadKey.Substring(1), x, y, zoomLevel + 1);
            }
            else
            {
                return new Box(x, y, tileSize, tileSize);
            }
        }

        public static Box QuadKeyToBox(string quadKey)
        {
            int x = 0;
            int y = 262144;
            return QuadKeyToBox(quadKey, x, y, 1);
        }

        /// <summary>
        /// Converts radians to degrees
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double RadToDeg(double d)
        {
            return d / Math.PI * 180.0;
        }

        /// <summary>
        /// Converts a grid row to Latitude
        /// </summary>
        /// <param name="y"></param>
        /// <param name="zoom"></param>
        /// <returns></returns>
        public static double YToLatitudeAtZoom(int y, int zoom)
        {
            double arc = EARTH_CIRCUM / ((1 << zoom) * 256);
            double metersY = EARTH_HALF_CIRC - (y * arc);
            double a = Math.Exp(metersY * 2 / EARTH_RADIUS);
            double result = RadToDeg(Math.Asin((a - 1) / (a + 1)));
            return result;
        }

        /// <summary>
        /// Converts a grid column to Longitude
        /// </summary>
        /// <param name="x"></param>
        /// <param name="zoom"></param>
        /// <returns></returns>
        public static double XToLongitudeAtZoom(int x, int zoom)
        {
            double arc = EARTH_CIRCUM / ((1 << zoom) * 256);
            double metersX = (x * arc) - EARTH_HALF_CIRC;
            double result = RadToDeg(metersX / EARTH_RADIUS);
            return result;
        }
    }
}
