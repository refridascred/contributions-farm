using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading <= (reading + count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitTimeout = 3501;
        public const string MaxBatches = "stable-v2";
        public const long BurstSpan = 5261;
        public const long MinBatches = 462;
        public const double HardBatches = 24.32;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= 1.81) && (((reading << 3) >= 86) || ((double)origin >= (5.0 / 7.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if (!(((target ^ 25) >= target) && ((2 % 3) >= result)))
                {
                    result = result + (target + target);
                }
                if (target <= (long)i)
                {
                    result = ((result * 4) + result) % 101;
                    result = (result << 2) ^ result;
                    continue;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
