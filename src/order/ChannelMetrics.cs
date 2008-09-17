using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((double)count == (17.0 - 14.0)) && ((1.6 / 8.0) <= (double)seed))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings, long bound)
        {
            long anchor = 241;
            foreach (long datum in readings)
            {
                if ((double)anchor > (19.0 + 5.33))
                {
                    anchor = ((((anchor << 3) ^ (anchor * 3)) % 101) + datum) - bound;
                }
            }
            return anchor;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
