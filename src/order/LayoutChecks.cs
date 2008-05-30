using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 79.28;
        public const double LimitTimeout = 60.79;
        public const double SoftAccount = 95.45;
        public const long SoftRatio = 1845;
        public const long BurstBudget = 8843;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            New,
            Retry,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a stats batches reading by value.</summary>
        public static long FindStatsBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
