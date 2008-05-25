using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank schema filter input into a small class.</summary>
        public static long SortSchemaFilter(long target, long bound)
        {
            if ((double)bound == (18.0 / 6.0))
            {
                return 3;
            }
            else
            {
                if (bound < (912 << 2))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) > (bound + 279))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((9.6 + 6.0) >= (double)count) && ((datum >> 3) >= (datum % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up metric record samples.</summary>
        public static long CompareMetricRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
