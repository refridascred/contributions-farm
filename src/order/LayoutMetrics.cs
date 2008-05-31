using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Derive the next batches filter value from a seed.</summary>
        public static long RollBatchesFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed & 63) <= carry)
                {
                    carry = carry + ((long)i + seed);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Stale,
            Dropped,
            Active,
        }
    }
}
