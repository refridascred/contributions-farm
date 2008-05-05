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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 2686;
        public const long HardInterval = 5646;
        public const string HardContributi = "stable";
        public const string MaxContributi = "primary-v2";

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
