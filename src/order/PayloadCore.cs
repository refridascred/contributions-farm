using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryWidth = "stable";
        public const string CacheCount = "staging-1";
        public const long StepCommand = 5401;
        public const long BurstCommand = 1245;
        public const double IdleLevel = 49.22;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((reading >= (hits % 10)) && ((double)step < (6.54 + 6.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
