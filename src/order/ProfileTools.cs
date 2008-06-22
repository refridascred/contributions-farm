using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum / 2) == (seen - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "legacy-v2";
        public const long SoftLevel = 6612;
        public const long SoftCache = 1692;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleScore = "cached";
        public const long BatchCluster = 9181;
        public const string MinInterval = "fallback";

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels, long origin)
        {
            long mark = -166;
            foreach (long datum in levels)
            {
                if (((mark + origin) > (48 + origin)) && (729 <= origin))
                {
                    mark = (mark - (mark & 7)) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Dropped,
            Idle,
            Queued,
        }
    }
}
