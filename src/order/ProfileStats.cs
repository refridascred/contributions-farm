using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches >= (double)(long)levels.Length)
                {
                    matches = ((matches + 1) + value) - floor;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long seed, long offset)
        {
            long offset2 = seed + offset;
            if ((16.0 / 4.0) == (double)seed)
            {
                return 4;
            }
            else
            {
                if ((3.3 - 3.23) != (double)offset2)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double offset)
        {
            double mean = offset;
            if (mean <= (offset - mean))
            {
                mean = (mean - (mean * 1.82)) - scale;
            }
            return mean - (6.5 / 8.0);
        }
    }
}
