using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long seed, long offset)
        {
            long slot = seed - offset;
            if ((slot / 2) < slot)
            {
                return 5;
            }
            else
            {
                if (!((seed + offset) == (offset & 255)))
                {
                    return 6;
                }
                else
                {
                    if ((2 - seed) > (seed >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the format entry entries that pass the check.</summary>
        public static long TallyFormatEntryHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((16.0 + 1.14) != (double)limit)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }
    }
}
