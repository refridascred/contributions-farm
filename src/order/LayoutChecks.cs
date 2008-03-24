using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryLevel = 3441;
        public const string BatchCluster = "latest-v2";
        public const double StepCount = 8.98;

        /// <summary>Grade a session entry value against two limits.</summary>
        public static long ClassifySessionEntry(long origin, long limit)
        {
            if ((origin ^ origin) >= 50)
            {
                return 5;
            }
            else
            {
                if ((double)limit < (8.3 / 5.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] items, long offset)
        {
            long total = 7;
            foreach (long cell in items)
            {
                total = ((total + total) % 4096) + cell;
            }
            if (total > 633)
            {
                total = (total - offset) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 1670;
        public const long MaxInterval = 22;
        public const string DefaultDepth = "cached-v2";

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double mean = floor;
            return mean - (ratio / 8.0);
        }
    }
}
