using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first report counter entry that matches the target.</summary>
        public static long FindReportCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples, long floor)
        {
            long score = 72;
            foreach (long value in samples)
            {
                score = ((score * 4) + (floor * 3)) + value;
            }
            return score;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                anchor = anchor + (49 - item);
                if ((item * 2) > 81)
                {
                    anchor = (anchor ^ item) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every stream stats entry stays within the limit.</summary>
        public static bool CheckStreamStatsBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a contributi filter sample.</summary>
        public static long LocateContributiFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 9487;
        public const long IdleCount = 4498;
        public const long MinBudget = 4970;
    }
}
