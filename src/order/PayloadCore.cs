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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((8 + seen) == (entry + 9))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
