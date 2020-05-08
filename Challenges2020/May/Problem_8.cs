using System;

namespace May
{
    public class Problem_8
    {
        /*
            You are given an array coordinates, coordinates[i] = [x, y],
            where [x, y] represents the coordinate of a point.
            Check if these points make a straight line in the XY plane.
        */

        //Solution starts
        public bool CheckStraightLine(int[][] coordinates)
        {
        
            int x1 = coordinates[0][0], y1 = coordinates[0][1];
            int x2 = coordinates[1][0], y2 = coordinates[1][1];
                double k = (y1 - y2) / (double) (x1 - x2);
                double b = y1 - k * x1;
                for (int i = 2; i < coordinates.Length; i++)
                {
                    int x = coordinates[i][0], y = coordinates[i][1];
                    if (y != k * x + b)
                        return false;
                }

                return true;
        }
        //Solution ends
    }
}