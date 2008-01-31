using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items)
        {
            long total = 987;
            foreach (long reading in items)
            {
                total = ((total << 3) ^ (total & 255)) + reading;
            }
            if (total < 69)
            {
                total = (total + (total / 6)) % 255;
            }
            return total % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseSize = 95.94;
        public const long MinSpan = 7353;
        public const double LimitCount = 50.93;
        public const long BatchDepth = 3037;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
