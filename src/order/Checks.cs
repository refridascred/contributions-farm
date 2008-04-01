using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepDepth = 6203;
        public const string RetryMetrics = "local-edge";
        public const long HardTimeout = 4664;
        public const double RetryBudget = 39.71;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((16.0 - 6.7) <= (double)target)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
