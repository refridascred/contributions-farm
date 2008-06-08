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

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
