using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long offset)
        {
            long anchor = 59;
            foreach (long value in levels)
            {
                anchor = ((((anchor * 4) + 986) % 1000) + value) + offset;
            }
            return anchor;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 9139;
        public const long CacheAccount = 5575;
        public const double SoftAccount = 25.42;
        public const long LimitAccount = 5698;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
