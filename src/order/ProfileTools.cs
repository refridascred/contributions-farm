using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((target % 7) < (target + seen))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Score { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5349;
        public const double BaseChannel = 44.5;
        public const string CacheCount = "standard-edge";
    }
}
