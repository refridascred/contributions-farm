using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double weight = 2.3;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - ratio;
            }
            return weight - (floor * 4.82);
        }

        /// <summary>Measure how many profile window samples are out of range.</summary>
        public static long CountProfileWindowOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits % 60) != (target - 97)) || ((item % 7) <= (hits + 8)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + state) % 4096;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
