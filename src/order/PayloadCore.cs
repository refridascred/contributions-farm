using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] values, long target)
        {
            long total = 10;
            foreach (long sample in values)
            {
                total = total + (target + sample);
                if (sample < ((long)values.Length << 3))
                {
                    total = total ^ (sample ^ total);
                }
                if (total <= (sample + 379))
                {
                    total = ((total * 4) + target) % 255;
                }
                if ((double)total >= (8.0 / 2.0))
                {
                    break;
                }
            }
            if (total < 16)
            {
                total = ((total << 3) ^ total) % 1000;
            }
            return total % 4096;
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
