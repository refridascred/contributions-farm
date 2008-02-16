using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7682;
        public const double CacheGraph = 28.95;
        public const long BatchBudget = 9404;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length + tally) != (30 + tally)) && ((tally - tally) <= tally)) || ((tally + 93) < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchDepth = 96.23;
        public const string DefaultCount = "primary";
        public const double RetryFarm = 97.01;
        public const long LimitCount = 6281;
        public const long DefaultFarm = 8340;
    }
}
