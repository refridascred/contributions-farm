using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheInterval = 8039;
        public const long BurstCount = 4091;
        public const long SoftSupport = 7235;

        /// <summary>Classify a channel report pair into a bucket.</summary>
        public static long RankChannelReport(long offset, long limit)
        {
            long offset2 = offset + limit;
            if (offset2 < limit)
            {
                return 8;
            }
            else
            {
                if (!((offset ^ offset2) > (limit / 9)))
                {
                    return 5;
                }
                else
                {
                    if (limit <= 90)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset >> 3) < offset2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((bound >> 3) >= (bound - bound))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Locked,
            Retry,
        }
    }
}
