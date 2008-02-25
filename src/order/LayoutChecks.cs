using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long next = step + seed;
            if (((double)next >= (3.02 * 8.76)) || ((seed + seed) >= step))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 8.22) != (double)next)
                {
                    return 2;
                }
                else
                {
                    if (next <= (3 + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepTimeout = 52.86;
        public const long RetryStream = 1286;
        public const double RetryFactor = 74.99;
        public const long SoftSize = 2591;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((16.0 + 14.0) > (double)hits)
                {
                    hits = ((hits + 1) + sample) - seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report checks samples are out of range.</summary>
        public static long CountReportChecksOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((2.0 / 9.0) <= (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin <= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
