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

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = (total - (floor & 127)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
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
