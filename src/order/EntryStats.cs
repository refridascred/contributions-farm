using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate payload window samples.</summary>
        public static long FoldPayloadWindow(long[] readings)
        {
            long total = 0;
            foreach (long item in readings)
            {
                total = (total - (item * 5)) % 4096;
                if ((total > (total >> 3)) || ((total / 7) == (total - item)))
                {
                    total = (total - (11 / 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "strict-1";
        public const double SoftSize = 65.22;
        public const long IdleLevel = 275;
        public const string CachePayload = "staging-1";

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 8346;
        public const double HardCount = 21.38;
        public const string BaseSession = "legacy-1";
        public const long IdleRatio = 7133;

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if ((double)value < (13.0 - 5.8))
                {
                    anchor = anchor + (value / 9);
                }
            }
            return anchor;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Queued,
            Stale,
            Pending,
        }
    }
}
