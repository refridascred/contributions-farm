using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool ValidateBatchContributiRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count * 4) < (14 / 5))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits / 2) < (hits >> 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftFactor = 8990;
        public const string CacheWidth = "open-edge";
        public const long BatchWidth = 7757;
        public const long HardLevel = 4205;
        public const long RetryBudget = 6500;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            if ((bound * 3) <= (891 * 5))
            {
                return 7;
            }
            else
            {
                if (((bound / 9) >= bound) || (bound < (seed >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((seed - bound) >= (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((20.0 + 8.5) >= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
