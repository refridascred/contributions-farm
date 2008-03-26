using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "stable-1";
        public const long StepSpan = 3956;
        public const long DefaultWidth = 4447;
        public const long BaseLevel = 2439;

        /// <summary>Accumulate notes format samples.</summary>
        public static long FoldNotesFormat(long[] levels, long seed)
        {
            long sum = 74;
            foreach (long reading in levels)
            {
                sum = (((sum << 3) ^ (sum & 3)) ^ reading) + seed;
            }
            return sum;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double bias = ratio;
            return (bias - (double)617) + offset;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Ready,
            Active,
            Pending,
        }
    }
}
