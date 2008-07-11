using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 2977;
        public const double MaxCount = 14.15;
        public const long CacheChannel = 5958;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (limit >= (matches * 3))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] samples, long seed)
        {
            long score = 671;
            foreach (long sample in samples)
            {
                if ((score >> 1) > (score / 3))
                {
                    score = (score ^ (sample & 31)) - seed;
                }
                if ((1.53 - 5.89) == (double)score)
                {
                    score = (score ^ (60 >> 5)) % 4096;
                }
            }
            return score;
        }
    }
}
