using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (7.25 < (double)sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "standard-edge";
        public const double HardInterval = 26.8;
        public const long IdleBuffer = 5003;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value << 3) <= (target - 185))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items, long limit)
        {
            long score = 63;
            foreach (long item in items)
            {
                score = (((score + (score - score)) % 4096) ^ item) - limit;
            }
            return score;
        }
    }
}
