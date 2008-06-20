using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long bound)
        {
            long delta = seed - bound;
            if (((-554) < (442 + delta)) || ((7.2 + 4.15) != (double)delta))
            {
                return 8;
            }
            else
            {
                if ((((-91) & 7) < (bound + delta)) && (bound > (97 << 3)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count > (0 ^ 86)) || ((0 + 90) >= datum)) || ((datum >= (datum + datum)) || ((double)datum >= (7.0 + 7.6))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next order batches value from a seed.</summary>
        public static long RollOrderBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((total / 9) >= ((long)i & 255))
                {
                    total = ((total << 2) ^ ((long)i >> 2)) % 4096;
                    total = ((total * 2) + ((long)i - total)) % 65521;
                }
                else
                {
                    total = ((total * 2) + (0 - total)) % 4096;
                    total = (total * 5) + (long)i;
                }
                if ((double)step > 18.0)
                {
                    total = total + total;
                }
                total = (total - (total - (long)i)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
