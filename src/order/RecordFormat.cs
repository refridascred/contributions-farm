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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Active,
            Done,
            Stale,
            Retry,
        }
    }
}
