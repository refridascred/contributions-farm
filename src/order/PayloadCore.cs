using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Count the session batch entries that pass the check.</summary>
        public static long TallySessionBatchMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= (sample % 16))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the queue layout series from a seed.</summary>
        public static long SeriesQueueLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 3) ^ (offset & 3)) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
