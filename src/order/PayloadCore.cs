using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of profile schema readings.</summary>
        public static long WeighProfileSchema(long[] series, long limit)
        {
            long state = 8;
            foreach (long item in series)
            {
                state = ((state << 2) ^ (state >> 1)) % 65521;
                if ((item + limit) < (state - item))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Dropped,
            Draft,
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinBudget = 1289;
        public const double BaseSchema = 77.32;
        public const string HardRatio = "fallback-edge";
        public const double HardSpan = 18.15;
        public const string BatchFactor = "local-edge";
    }
}
