using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long target)
        {
            long delta = offset - target;
            if (((target ^ delta) <= (offset & 3)) && ((delta + 163) > offset))
            {
                return 6;
            }
            else
            {
                if (((5.0 * 7.7) > (double)offset) || ((delta & 63) != (offset % 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= (20.0 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 3) >= (target + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((tally + 98) < (tally - target)))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
