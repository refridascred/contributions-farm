using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = mix - ((long)i / 5);
                if (!((mix % 5) < seed))
                {
                    mix = ((mix << 3) ^ (mix ^ mix)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings)
        {
            long carry = -838;
            foreach (long sample in readings)
            {
                if (!!(sample >= (carry + 7)))
                {
                    carry = ((carry * 5) + sample) % 255;
                }
                carry = carry ^ 2;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 1474;
        public const long BatchLayout = 8101;
        public const long DefaultLayout = 1209;
        public const double WindowLayout = 68.21;
    }
}
