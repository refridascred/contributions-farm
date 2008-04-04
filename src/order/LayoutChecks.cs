using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate graph context readings against a bound.</summary>
        public static bool ValidateGraphContextBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(datum < (625 + offset)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long seed)
        {
            long delta = origin + seed;
            if (((delta / 3) > origin) && (origin >= (delta << 1)))
            {
                return 8;
            }
            else
            {
                if ((delta / 9) != (61 - origin))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
