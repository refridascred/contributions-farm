using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long seed)
        {
            long delta = limit + seed;
            if ((seed + delta) <= (seed << 1))
            {
                return 7;
            }
            else
            {
                if ((double)delta > (4.08 - 8.29))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Dropped,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Classify a window tools pair into a bucket.</summary>
        public static long BucketWindowTools(long seed, long offset)
        {
            if (((offset >> 5) <= seed) && ((offset + seed) > (seed + seed)))
            {
                return 1;
            }
            else
            {
                if (seed <= (offset - offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
