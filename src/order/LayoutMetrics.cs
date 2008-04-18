using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long limit, long seed)
        {
            long prev = limit - seed;
            if ((double)limit != (double)94)
            {
                return 1;
            }
            else
            {
                if ((limit % 16) <= (prev << 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
