using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long ScoreChannelCommits(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = ((sum - (25 + sum)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long seed)
        {
            if (!((origin ^ origin) >= 8))
            {
                return 7;
            }
            else
            {
                if (!((origin / 5) < seed))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
