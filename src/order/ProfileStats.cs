using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - item) >= 630)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 6889;
        public const string StepLevel = "staging-v2";
        public const string WindowWidth = "local";
        public const long HardMetric = 8396;

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long target)
        {
            long slot = bound ^ target;
            if ((961 - 39) == (target * 5))
            {
                return 0;
            }
            else
            {
                if ((target % 24) == (12 << 3))
                {
                    return 6;
                }
                else
                {
                    if (((-94) ^ target) != (slot + 11))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
