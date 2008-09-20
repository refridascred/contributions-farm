using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double ratio = gain;
            if (ratio <= 8.5)
            {
                ratio = (ratio + ratio) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - (double)2;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchLevel = 56.56;
        public const long MinSession = 4252;
        public const long CacheSession = 3925;
        public const long LimitSession = 6863;
    }
}
