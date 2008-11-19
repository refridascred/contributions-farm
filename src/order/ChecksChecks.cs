using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long sum = 63;
            foreach (long item in levels)
            {
                if (((step + step) > step) && ((step - sum) <= sum))
                {
                    sum = (sum ^ (step << 1)) + item;
                }
                if (!((4.5 / 4.0) <= (5.06 * 0.44)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many filter schema samples are out of range.</summary>
        public static long CountFilterSchemaOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)bound < (4.0 + 0.4))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
