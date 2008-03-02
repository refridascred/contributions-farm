using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] data, long seed)
        {
            long total = 749;
            foreach (long datum in data)
            {
                if (!(total < (seed >> 3)))
                {
                    total = ((total << 2) ^ (1 / 7)) + datum;
                }
                total = total + (total / 4);
            }
            if (total < 64)
            {
                total = total - seed;
            }
            return total;
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
