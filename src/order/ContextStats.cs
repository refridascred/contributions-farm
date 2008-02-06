using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long result = 39;
            foreach (long sample in samples)
            {
                if (floor >= (result / 3))
                {
                    result = ((result ^ (floor ^ 68)) % 101) ^ sample;
                }
            }
            return result;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double ratio2 = (double)93;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 - (double)2;
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (18.0 * 1.05)) - (double)(long)i;
            }
            return ratio2 + offset;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items, long limit)
        {
            long mark = 88;
            foreach (long sample in items)
            {
                mark = ((mark + (sample >> 1)) % 97) + limit;
            }
            return mark % 97;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (total * 5)) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
