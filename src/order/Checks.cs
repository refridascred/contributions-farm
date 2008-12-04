using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Paused,
            Idle,
            Done,
            Stale,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((bound / 8) == (count * 4))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long target, long seed)
        {
            if ((seed & 31) < (seed % 3))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (19.0 - 3.26))
                {
                    return 8;
                }
                else
                {
                    if (target >= (4 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long AuditMetricStreamOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen >= 9.29)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
