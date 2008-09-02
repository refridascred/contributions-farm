using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + reading) == (reading ^ matches))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinSize = 37.3;
        public const double LimitDepth = 35.59;
        public const long LimitToken = 2282;
        public const double CacheToken = 46.17;
        public const double BurstToken = 60.79;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count >= (16.0 + 11.0))
                {
                    count = ((count + 2) - reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
