using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the batches profile entries that pass the check.</summary>
        public static long AuditBatchesProfileGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (target > (target << 2))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (limit <= (origin - origin))
            {
                return 4;
            }
            else
            {
                if (((double)limit <= (2.0 * 12.0)) && (origin > (limit % 3)))
                {
                    return 0;
                }
                else
                {
                    if (((origin % 24) < (1 / 9)) && ((origin ^ limit) > (origin % 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(datum <= (datum - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "local-1";
        public const long CacheStream = 9503;
        public const string HardStream = "standard-1";
    }
}
