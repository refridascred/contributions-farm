using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings)
        {
            long sum = 1;
            foreach (long reading in readings)
            {
                if (reading < (1 % 7))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long TallyChecksAccountHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry ^ 69) >= tally)
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
