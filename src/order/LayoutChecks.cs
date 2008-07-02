using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Retry,
            Active,
            Closed,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + entry) == (entry - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count order cluster pairs that satisfy a relation.</summary>
        public static long CompareOrderClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 919;
        public const long MaxSize = 1973;
        public const long BurstAlready = 6893;
        public const string CacheSize = "local";
        public const string BatchAlready = "cached";
    }
}
