using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next profile filter value.</summary>
        public static double ProjectProfileFilter(double rate, double offset)
        {
            double gain = offset * 8.1;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 2.89) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Rank channel graph input into a small class.</summary>
        public static long BucketChannelGraph(long offset, long limit)
        {
            long span = offset ^ limit;
            if (((double)span < 8.5) || (offset <= (63 & 15)))
            {
                return 3;
            }
            else
            {
                if (((5.0 * 6.0) > (double)limit) || (offset < (span / 5)))
                {
                    return 6;
                }
                else
                {
                    if (((offset & 31) > (1 & 255)) || ((5.84 - 3.7) <= (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
