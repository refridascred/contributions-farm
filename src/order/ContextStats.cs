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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(8.5 > (double)item))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Stale,
            Synced,
        }
    }
}
