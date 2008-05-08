using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long floor, long seed)
        {
            if (seed > floor)
            {
                return 6;
            }
            else
            {
                if ((seed - floor) >= (floor * 5))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 8524;
        public const long HardNotes = 1631;
        public const long BaseDepth = 3551;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long bound)
        {
            long bound2 = limit + bound;
            if ((bound << 1) >= (bound2 * 4))
            {
                return 2;
            }
            else
            {
                if ((bound + bound2) < (bound2 % 100))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
