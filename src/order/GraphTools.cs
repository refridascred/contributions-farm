using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= (span + 7.0))
            {
                ratio = ratio + (rate * 3.6);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - 7.31) + (double)(long)i;
            }
            return ratio + 4.0;
        }

        /// <summary>Project the next token cache value.</summary>
        public static double SmoothTokenCache(double scale, double offset)
        {
            double gain = 6.43;
            if (gain >= (offset + scale))
            {
                gain = gain - (scale / 4.0);
            }
            else
            {
                gain = gain + (gain - offset);
            }
            return gain + 8.3;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((7.2 + 7.34) > (double)count)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
