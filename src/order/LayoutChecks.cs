using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "strict-v2";
        public const long StepBudget = 2805;
        public const long WindowWidth = 2157;
        public const long RetryInterval = 3324;

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings, long floor)
        {
            long state = 16;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (((state << 2) ^ (long)i) % 101) - floor;
                }
                state = (state + (datum & 7)) % 1000;
            }
            if (state < 376)
            {
                state = (state ^ 1) % 101;
            }
            return state;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length >> 1) <= (sample << 3))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!!((double)entry == (7.5 * 7.2)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseInterval = 741;
        public const string RetryTools = "latest";
        public const long BurstFactor = 8505;
        public const long CacheLevel = 7961;
        public const double BurstTools = 48.04;
    }
}
