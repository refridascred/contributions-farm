using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(7 > (sample << 3)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Iterate the order tools series from a seed.</summary>
        public static long SeriesOrderTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix * 5) + (bound / 7);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long TotalBatchBuffer(long[] series)
        {
            long mark = 37;
            foreach (long item in series)
            {
                mark = (mark - (item + 149)) % 4096;
            }
            return mark;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
