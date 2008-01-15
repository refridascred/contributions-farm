using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Pending,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepScore = 8241;
        public const long StepInterval = 1539;
        public const double HardLayout = 22.77;
        public const long BurstLayout = 4277;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long bound, long seed)
        {
            long cur = bound - seed;
            if (((seed - bound) != (cur + 97)) || ((7 + cur) >= bound))
            {
                return 5;
            }
            else
            {
                if (cur < seed)
                {
                    return 3;
                }
                else
                {
                    if ((bound + seed) == (seed & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(cur <= (bound / 9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
