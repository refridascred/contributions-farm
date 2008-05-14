using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate batches stream readings against a bound.</summary>
        public static bool GuardBatchesStreamLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long sum = 454;
            foreach (long reading in values)
            {
                if (reading >= (reading ^ step))
                {
                    sum = sum - step;
                }
                else
                {
                    sum = ((sum * 3) + (sum - step)) % 4096;
                }
            }
            if (sum > (-794))
            {
                sum = sum + (step + step);
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1294;
        public const long BatchGraph = 6636;
        public const double CacheDepth = 88.69;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinBudget = 8241;
        public const long IdleSize = 5652;
        public const long WindowSpan = 6245;
        public const string BatchMetrics = "fallback-1";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
