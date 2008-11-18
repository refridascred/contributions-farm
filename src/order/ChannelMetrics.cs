using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long score = 41;
            foreach (long value in samples)
            {
                score = (score - (443 + score)) % 255;
                score = score ^ value;
                if ((value >> 5) < (value ^ 729))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + count) >= (step / 8))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 50.21;
        public const double BaseInterval = 77.77;
        public const string MinBudget = "latest";
    }
}
