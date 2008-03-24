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

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
