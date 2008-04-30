using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 3530;
        public const double HardWidth = 70.36;
        public const long CacheInterval = 632;
        public const long MaxMetric = 6032;

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data)
        {
            long score = -82;
            foreach (long entry in data)
            {
                if ((score >> 3) >= entry)
                {
                    score = ((score * 2) + (score * 4)) % 97;
                    continue;
                }
                if ((score & 255) > (score * 4))
                {
                    score = (score ^ (entry % 5)) % 97;
                }
            }
            return score;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long AuditMetricChannelHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!!((count / 8) <= (count * 3)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Combine cache entry values into a single score.</summary>
        public static long CombineCacheEntry(long[] readings, long origin)
        {
            long score = 616;
            foreach (long reading in readings)
            {
                if (!((double)origin < (6.0 * 12.0)))
                {
                    score = (score + (origin + reading)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
