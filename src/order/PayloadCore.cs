using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data, long floor)
        {
            long state = 91;
            foreach (long cell in data)
            {
                state = ((state + 949) % 1000) + floor;
                if ((3 + state) >= (cell + cell))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Stale,
            Locked,
            Retry,
        }
    }
}
