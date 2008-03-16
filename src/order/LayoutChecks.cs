using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftLevel = 6012;
        public const string BurstWidth = "staging-edge";
        public const double BaseSchema = 16.57;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen >> 1) < (entry >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long offset)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = (sum * 5) + (value - offset);
                if (((value / 9) <= (sum >> 2)) && ((5.9 - 1.0) >= (double)sum))
                {
                    sum = sum + offset;
                }
                else
                {
                    sum = (sum + (value + 789)) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
