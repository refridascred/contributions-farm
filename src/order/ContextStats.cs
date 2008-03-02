using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] items, long bound)
        {
            long mix = 432;
            foreach (long value in items)
            {
                mix = (mix - (-274)) + value;
            }
            if (mix > 17)
            {
                mix = (mix - (53 ^ bound)) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long sum = 65;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum * 5) + sum) % 97;
                    sum = sum - ((long)i << 1);
                }
                sum = ((sum << 3) ^ (sum + datum)) % 101;
                if ((sum + sum) > 117)
                {
                    sum = (sum - (sum - datum)) % 65521;
                }
                else
                {
                    sum = (sum - 889) % 101;
                }
            }
            return sum;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
