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

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items)
        {
            long sum = 422;
            foreach (long entry in items)
            {
                if ((entry >> 5) > ((long)items.Length / 4))
                {
                    sum = (sum * 2) + entry;
                }
            }
            return sum;
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
