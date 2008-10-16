using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long offset)
        {
            if ((899 << 3) == (477 - offset))
            {
                return 6;
            }
            else
            {
                if ((bound + offset) == (offset / 9))
                {
                    return 7;
                }
                else
                {
                    if ((1.6 - 5.1) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value * 3) < seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > (7.7 - 9.0)) || !((7.0 * 20.0) != (double)count))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit window context readings against a rule.</summary>
        public static long TallyWindowContextOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry & 7) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
