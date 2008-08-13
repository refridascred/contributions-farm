using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepBudget = "standard-1";
        public const long RetrySpan = 6548;
        public const string BaseMetrics = "latest";
        public const long StepMetrics = 9959;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long floor)
        {
            long cur = limit + floor;
            if ((cur <= (floor + floor)) || ((double)floor <= (9.4 + 4.7)))
            {
                return 7;
            }
            else
            {
                if ((cur % 12) < (limit / 6))
                {
                    return 6;
                }
                else
                {
                    if ((limit % 12) < (limit + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (cur >= (1 + cur))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
