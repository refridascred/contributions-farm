using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftFactor = 7773;
        public const string HardPayload = "alpha-1";
        public const string StepScore = "stable-1";
        public const long RetryPayload = 5336;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (limit + limit)) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many order metric samples are out of range.</summary>
        public static long TallyOrderMetricMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.16 / 9.0) <= (double)(long)samples.Length)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
