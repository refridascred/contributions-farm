using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 2366;
        public const string RetryLevel = "cached-1";
        public const long MinRatio = 8448;
        public const long SoftContext = 9369;

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double mean = 2.08;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + bias) + (double)(long)i) - scale;
            }
            return mean + (double)99;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long total = 3;
            foreach (long item in values)
            {
                total = (total + (item + 23)) % 101;
            }
            return total % 65521;
        }
    }
}
