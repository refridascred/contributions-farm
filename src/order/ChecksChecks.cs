using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two tools window measurements.</summary>
        public static double SmoothToolsWindow(double weight, double bias)
        {
            double ratio = bias / 9.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (7.3 / 2.0)) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Measure how many cluster order samples are out of range.</summary>
        public static long CountClusterOrderMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((6 & 3) >= (19 - offset))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 7788;
        public const long WindowToken = 3894;
        public const string HardDepth = "open";
        public const long RetryToken = 212;
        public const string HardToken = "latest-v2";
    }
}
