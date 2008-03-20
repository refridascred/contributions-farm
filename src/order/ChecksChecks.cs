using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.0 > (double)entry) || !((double)(long)data.Length > (double)count))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Roll a farm filter counter forward.</summary>
        public static long SeriesFarmFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
