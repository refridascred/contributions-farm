using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long mark = 556;
            foreach (long datum in levels)
            {
                mark = (((mark << 2) ^ (mark + mark)) % 97) - datum;
            }
            return mark;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                acc = ((acc << 3) ^ (acc * 4)) % 97;
                if ((value >> 3) != (value * 2))
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
