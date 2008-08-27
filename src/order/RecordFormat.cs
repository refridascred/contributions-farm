using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitRatio = "legacy-edge";
        public const string BatchEditor = "local";
        public const double BaseTimeout = 1.27;
        public const long DefaultEditor = 2708;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound << 3) < (entry >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Failed,
            Queued,
            Active,
            Done,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Score { get; set; }
            public long Label { get; set; }
        }
    }
}
