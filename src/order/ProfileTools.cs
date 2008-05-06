using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading <= (reading + bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long limit)
        {
            if (((bound >> 2) >= bound) && ((limit - bound) >= bound))
            {
                return 8;
            }
            else
            {
                if ((4 + bound) >= 57)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstRatio = 67.78;
        public const long HardSize = 8687;
        public const long CacheSpan = 9072;
    }
}
