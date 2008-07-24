using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long offset, long offset2)
        {
            long span = offset + offset2;
            if (((double)874 <= (double)span) || ((3.5 * 2.49) != (double)span))
            {
                return 4;
            }
            else
            {
                if ((offset2 + offset2) > offset2)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Region { get; set; }
            public long Score { get; set; }
        }
    }
}
