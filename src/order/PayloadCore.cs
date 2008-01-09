using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                long hits = origin << 3;
                if ((hits + total) == (hits ^ total))
                {
                    total = (total + (hits + origin)) % 4096;
                    hits = (hits * 5) + ((long)i >> 3);
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values)
        {
            long mix = 46;
            foreach (long value in values)
            {
                if ((mix + value) >= (value % 5))
                {
                    mix = ((mix << 2) ^ mix) % 65521;
                }
                else
                {
                    mix = (mix - (value + value)) % 1000;
                }
                if (((double)value != (9.4 + 0.1)) && ((double)mix <= 9.3))
                {
                    break;
                }
            }
            if (mix > 609)
            {
                mix = (mix + (162 + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Synced,
            Ready,
        }
    }
}
