using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 59.16;
        public const long BurstBudget = 9044;
        public const long IdleGraph = 583;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count / 4) >= (entry - 83))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "standard-1";
        public const double StepGraph = 82.3;
        public const long CacheSize = 3696;

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
