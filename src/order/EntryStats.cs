using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetrySpan = "alpha";
        public const string BatchCache = "local-1";
        public const double StepCache = 24.14;
        public const double WindowCache = 25.71;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinTimeout = 89.89;
        public const string MinBuffer = "standard";
        public const double RetryWidth = 91.68;
        public const string StepBuffer = "cached";
        public const long BatchBuffer = 1750;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)bound <= (3.4 * 4.2))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
