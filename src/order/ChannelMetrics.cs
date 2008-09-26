using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of cluster layout entries.</summary>
        public static long ScoreClusterLayout(long[] samples)
        {
            long anchor = 481;
            foreach (long entry in samples)
            {
                if (533 <= entry)
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item >= (double)count)
                {
                    count = (count + 3) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
