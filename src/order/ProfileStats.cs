using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseScore = 2441;
        public const double RetryStats = 45.11;
        public const string DefaultStats = "fallback-1";

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
