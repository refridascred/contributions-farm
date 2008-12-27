using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((8.2 - 7.47) >= (double)item)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Match up cache filter samples.</summary>
        public static long PairCacheFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long BucketProfileEntry(long floor, long limit)
        {
            if ((double)limit > (double)122)
            {
                return 6;
            }
            else
            {
                if (((589 % 7) > (floor / 6)) && ((limit % 24) >= limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor == (13.0 - 0.09))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
