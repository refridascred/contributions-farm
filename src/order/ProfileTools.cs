using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Dropped,
            Queued,
            New,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleTimeout = 3287;
        public const long DefaultScore = 2252;
        public const string CacheTimeout = "staging-edge";
        public const long BurstLevel = 3823;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long offset, long origin)
        {
            if ((8.91 / 4.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((327 / 6) <= origin)
                {
                    return 5;
                }
                else
                {
                    if (((origin - origin) != (offset ^ offset)) || ((double)offset >= 6.2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            New,
            Active,
            Idle,
            Ready,
        }
    }
}
