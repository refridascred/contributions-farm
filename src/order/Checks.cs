using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxPayload = 91.55;
        public const long WindowPayload = 6353;
        public const long BasePayload = 3309;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long limit)
        {
            if ((3.39 + 3.3) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((804 * 5) <= (limit >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((5.0 * 20.0) != (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
