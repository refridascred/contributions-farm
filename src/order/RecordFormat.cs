using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the commits token entries that pass the check.</summary>
        public static long TallyCommitsTokenGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count >= sample) || (((count - offset) == (offset - offset)) || ((sample / 2) >= 58)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTimeout = "primary-edge";
        public const long CacheTools = 5387;
        public const long LimitDepth = 2883;
        public const long DefaultBudget = 2300;
        public const long WindowTools = 2583;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 3782;
        public const long BurstBudget = 4100;
        public const long SoftContributi = 57;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
