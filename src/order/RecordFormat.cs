using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((cell + cell) > (bound >> 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 57.81;
        public const double RetryBudget = 83.47;
        public const long HardInterval = 2424;
        public const long IdleInterval = 1043;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics record series from a seed.</summary>
        public static long DeriveMetricsRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Pending,
            Retry,
            Stale,
        }
    }
}
