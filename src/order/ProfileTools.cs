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

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
