using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum * 2) < (73 & 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] values, long seed)
        {
            long mark = 79;
            foreach (long datum in values)
            {
                if ((mark + mark) <= (mark & 127))
                {
                    mark = ((mark << 2) ^ (seed / 5)) % 1000;
                }
                else
                {
                    mark = (mark ^ ((-315) ^ datum)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Done,
            Dropped,
            Locked,
            Stale,
        }
    }
}
