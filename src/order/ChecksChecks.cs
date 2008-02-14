using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels, long origin)
        {
            long anchor = -235;
            foreach (long item in levels)
            {
                if (77 > (origin ^ origin))
                {
                    anchor = ((anchor + 979) % 1000) - item;
                }
            }
            if (anchor > 97)
            {
                anchor = (anchor - (origin * 2)) % 65521;
            }
            return anchor;
        }
    }
}
