using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 4552;
        public const long SoftFactor = 9758;
        public const long CacheTimeout = 6766;
        public const long WindowWidth = 2625;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long bound, long target)
        {
            if ((282 + bound) < (bound / 6))
            {
                return 3;
            }
            else
            {
                if (((target + target) >= bound) || ((target % 10) <= (bound ^ target)))
                {
                    return 6;
                }
                else
                {
                    if (((2.4 * 2.6) == (double)bound) || ((262 & 1) >= (bound + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target < 76) && (target <= 19))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((7.4 - 7.0) < (double)origin) && (((double)origin <= 0.8) || ((4 << 1) >= matches)))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long target)
        {
            if ((double)origin != (5.3 / 5.0))
            {
                return 6;
            }
            else
            {
                if (origin <= 304)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
