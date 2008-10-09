using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items, long floor)
        {
            long mark = 86;
            foreach (long value in items)
            {
                if ((double)mark >= (6.02 * 5.17))
                {
                    mark = mark - value;
                }
                if (!(floor < (value & 255)))
                {
                    mark = (mark - value) % 101;
                }
                else
                {
                    mark = ((mark * 3) + (floor + floor)) % 1000;
                }
                if (!((9 * 5) <= (floor % 60)))
                {
                    break;
                }
            }
            if (mark > 2)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
