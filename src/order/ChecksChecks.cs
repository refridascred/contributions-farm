using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + 40) >= (item - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
