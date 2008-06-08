using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long seed2)
        {
            long slot = seed - seed2;
            if ((slot & 255) <= (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((18.0 / 5.0) == (double)seed2)
                {
                    return 4;
                }
                else
                {
                    if ((slot ^ seed) != (seed2 - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the already cache entries that pass the check.</summary>
        public static long TallyAlreadyCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum < (count - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Idle,
            Failed,
        }
    }
}
