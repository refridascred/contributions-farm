using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            New,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 1358;
        public const long BatchContributi = 5712;
        public const long RetryCount = 1856;
        public const double HardInterval = 15.13;
        public const long MinBudget = 9534;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 8772;
        public const string MinCount = "primary-v2";
        public const string CacheSize = "strict-1";
        public const long SoftMetrics = 4094;
        public const string LimitMetrics = "latest";

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (score >> 5)) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long CountSchemaFilterHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)target < 4.8)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
