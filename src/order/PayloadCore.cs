using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double weight = 0.5;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (floor + weight)) - (double)(long)i) + rate;
            }
            return weight - floor;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix + (target * 2)) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a filter checks figure with a bias.</summary>
        public static double SmoothFilterChecks(double scale, double bias)
        {
            double ratio = (double)(0 % 97);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(long)i) - bias;
            }
            return ratio + scale;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((origin - origin) <= (origin + 23))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
