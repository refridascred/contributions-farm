using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "open";
        public const double BurstLevel = 55.72;
        public const long CacheTimeout = 5559;
        public const double CacheStream = 35.01;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((3 * 2) >= hits)
                {
                    hits = ((hits + 2) + reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long limit)
        {
            if ((target >> 2) <= (target % 5))
            {
                return 6;
            }
            else
            {
                if ((limit >> 2) > (4 - target))
                {
                    return 7;
                }
                else
                {
                    if (((limit / 9) > target) && ((limit >> 4) < limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many checks metrics samples are out of range.</summary>
        public static long TallyChecksMetricsOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length ^ cell) < (offset + offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
