using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first channel graph entry that matches the target.</summary>
        public static long SeekChannelGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum >= count) || ((count << 2) > count)) || (((double)(long)values.Length < (double)count) || ((count << 2) <= (count % 97))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool VerifyGraphLayoutLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
