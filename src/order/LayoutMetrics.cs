using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples, long offset)
        {
            long mix = -53;
            foreach (long value in samples)
            {
                if ((mix + offset) > mix)
                {
                    mix = (mix + (offset * 5)) ^ value;
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ 16) % 1000;
                }
                mix = (mix - (offset + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark ^ 223) % 65521) ^ (long)i2;
                }
                mark = (mark ^ (long)i) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardFactor = "stable-1";
        public const long LimitRecord = 2933;
        public const long HardRecord = 1091;
    }
}
