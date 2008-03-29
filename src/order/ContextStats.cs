using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstTimeout = 4925;
        public const double CacheScore = 19.71;
        public const double StepInterval = 6.21;
        public const long BaseCount = 3987;

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values)
        {
            long mark = 264;
            foreach (long reading in values)
            {
                mark = (mark ^ reading) % 97;
                mark = mark ^ mark;
            }
            if (mark < 393)
            {
                mark = ((mark << 2) ^ (36 - mark)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                state = ((state ^ (state / 3)) ^ datum) + step;
            }
            return state % 4096;
        }
    }
}
