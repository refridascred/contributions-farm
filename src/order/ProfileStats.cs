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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long target)
        {
            if (((9.65 / 2.0) >= (double)floor) || ((double)floor < (2.6 * 4.3)))
            {
                return 8;
            }
            else
            {
                if ((target & 7) >= (6 - target))
                {
                    return 5;
                }
                else
                {
                    if (((double)floor != (5.9 + 6.33)) && ((target / 2) > target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor < (47 ^ 818)) && ((double)floor >= (6.25 * 6.8)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
