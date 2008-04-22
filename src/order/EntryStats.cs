using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a metric record counter forward.</summary>
        public static long DeriveMetricRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
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
