using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadTreeExplorer
{
    class Broken_DoNotUse
    {
        public TileDetails DoSomething(string quadtree)
        {
            // As assume a 1x1 quadtree space with a scale of 1
            TileDetails result = RecursiveWorker(quadtree, new TilePoint(0, 0), 1);

            // We scale up to world coordinates where x = 0-360 and y = 0-170.10225756
            result.Scale(360, -170.10225756);

            // We shift the 0,0 point from top left to center 
            result.Shift(-180, 85.05112878);


            return (result);
        }


        private TileDetails RecursiveWorker(string quadtree, TilePoint point, double scale)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("{3}:({0},{1}) / {2}", point.x, point.y, scale, quadtree));
            if (quadtree.Length > 0)
            {
                double delta = scale / 2;

                // do something
                switch (quadtree[0])
                {
                    case ('0'):
                        // do nothing
                        break;
                    case ('1'):
                        point.x = point.x + delta;
                        break;
                    case ('2'):
                        point.y = point.y + delta;
                        break;
                    case ('3'):
                        point.x = point.x + delta;
                        point.y = point.y + delta;
                        break;
                    default:
                        throw new Exception(string.Format("Invalid char found in quadtree: {0}", quadtree[0]));
                }
                return (RecursiveWorker(quadtree.Substring(1), point, delta));
            }
            else
            {
                TileDetails toReturn = new TileDetails();
                toReturn.tl = new TilePoint(point.x, point.y);
                toReturn.tr = new TilePoint(point.x + scale, point.y);
                toReturn.bl = new TilePoint(point.x, point.y + scale);
                toReturn.br = new TilePoint(point.x + scale, point.y + scale);

                return (toReturn);
            }
        }



        public class TileDetails
        {
            public TilePoint tl;   // Top Left
            public TilePoint tr;   // ... you the point
            public TilePoint bl;
            public TilePoint br;

            public void Scale(double xScale, double yScale)
            {
                tl.Scale(xScale, yScale);
                tr.Scale(xScale, yScale);
                bl.Scale(xScale, yScale);
                br.Scale(xScale, yScale);
            }

            public void Shift(double xShift, double yShift)
            {
                tl.Shift(xShift, yShift);
                tr.Shift(xShift, yShift);
                bl.Shift(xShift, yShift);
                br.Shift(xShift, yShift);
            }

        }

        public class TilePoint
        {
            public double x = 0;
            public double y = 0;

            public TilePoint(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return (string.Format("{0},{1}", y, x));
            }

            public void Scale(double xScale, double yScale)
            {
                x = x * xScale;
                y = y * yScale;
            }

            public void Shift(double xShift, double yShift)
            {
                x = x + xShift;
                y = y + yShift;
            }
        }
    }
}
