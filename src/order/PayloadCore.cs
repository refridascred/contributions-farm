using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Retry,
            New,
            Paused,
        }

        /// <summary>Check that every entry metrics entry stays within the limit.</summary>
        public static bool GuardEntryMetricsBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + mark) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Stale,
            Dropped,
            Failed,
            Synced,
        }
    }
}
