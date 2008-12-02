using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((53 & 31) <= ((long)readings.Length % 64)) || ((entry - 130) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache stats samples are out of range.</summary>
        public static long CountCacheStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + hits) < (hits % 7))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstCount = 15.19;
        public const long IdleReport = 393;
        public const string WindowReport = "open-v2";
        public const long MaxReport = 4060;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if (!(origin >= (origin << 1)))
            {
                return 5;
            }
            else
            {
                if (((origin - origin) >= origin) && ((6.0 * 9.0) < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if (((limit << 3) <= (origin - limit)) || (15.0 >= (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 2520;
        public const double LimitSize = 22.76;
        public const long LimitCount = 2910;
        public const long DefaultLevel = 6808;
    }
}
