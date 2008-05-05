using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(81 > entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 35.9;
        public const double LimitFactor = 51.3;
        public const long WindowLevel = 6015;
        public const double DefaultQueue = 95.24;
        public const long LimitSize = 1041;

        /// <summary>Audit metric entry readings against a rule.</summary>
        public static long CountMetricEntryMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count >= (count * 2))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Paused,
            Ready,
            Done,
        }
    }
}
