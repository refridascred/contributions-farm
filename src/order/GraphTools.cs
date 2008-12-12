using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first checks editor entry that matches the target.</summary>
        public static long LookupChecksEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report graph series from a seed.</summary>
        public static long IterateReportGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)bound < (5.99 * 2.12))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double weight = 9.5;
            if (weight > (double)52)
            {
                weight = (weight - (scale - 3.2)) + bias;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long bound)
        {
            long total = 36;
            foreach (long datum in readings)
            {
                if ((52 * 5) == (bound - total))
                {
                    total = total + (total % 8);
                }
                if (datum >= (bound + total))
                {
                    total = (total * 4) + (0 * 2);
                }
            }
            return total;
        }
    }
}
