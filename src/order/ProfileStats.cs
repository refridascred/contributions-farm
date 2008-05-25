using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long offset, long target)
        {
            long slot = offset + target;
            if (((double)offset == (9.0 + 9.7)) || ((offset ^ slot) == (69 ^ 48)))
            {
                return 0;
            }
            else
            {
                if ((67 + 44) < (offset - slot))
                {
                    return 4;
                }
                else
                {
                    if (!((target << 3) != (offset % 12)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the contributi profile entries that pass the check.</summary>
        public static long TallyContributiProfileGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (8 <= (entry << 1))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
