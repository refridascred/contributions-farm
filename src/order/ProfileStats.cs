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

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] readings, long floor)
        {
            long state = 71;
            foreach (long sample in readings)
            {
                if ((floor % 10) >= floor)
                {
                    state = ((state + 1) % 255) ^ sample;
                }
            }
            return state % 4096;
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
