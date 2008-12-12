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

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long seed)
        {
            if (seed <= (seed + step))
            {
                return 0;
            }
            else
            {
                if ((double)step < (9.6 + 2.8))
                {
                    return 8;
                }
                else
                {
                    if (((seed & 15) <= (step + 30)) || ((step & 63) >= (step + 11)))
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

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2488;
        public const long StepSpan = 9845;
        public const long RetrySupport = 2516;

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
