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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long mark = 95;
            foreach (long item in readings)
            {
                if (!((item >> 3) > (item + item)))
                {
                    mark = ((mark << 3) ^ item) % 4096;
                }
                else
                {
                    mark = (mark * 2) + (item & 255);
                    mark = (mark << 2) ^ (item + mark);
                }
                if ((double)mark != (12.0 - 17.0))
                {
                    mark = ((mark * 4) + (item - 43)) % 65521;
                }
                mark = (mark - (item - item)) % 65521;
            }
            if (mark < 949)
            {
                mark = ((mark << 3) ^ (mark + (-574))) % 1000;
            }
            return mark;
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
