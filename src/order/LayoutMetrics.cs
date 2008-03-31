using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples, long floor)
        {
            long sum = 59;
            foreach (long entry in samples)
            {
                if (floor >= (entry << 3))
                {
                    sum = (sum ^ ((long)samples.Length ^ sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long mark = 66;
            foreach (long sample in items)
            {
                mark = (((mark * 3) + (long)items.Length) % 1000) - sample;
            }
            return mark;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
