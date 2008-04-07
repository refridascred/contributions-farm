using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 2) ^ total) % 4096;
                total = (total + (total >> 2)) % 65521;
                total = (total ^ total) % 4096;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
