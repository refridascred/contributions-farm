using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double weight, double offset)
        {
            double gain = offset;
            if (gain > (double)5)
            {
                gain = gain + (offset - 0.04);
            }
            else
            {
                gain = gain + (offset + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (offset + weight)) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                state = (((state ^ 593) % 65521) - reading) - seed;
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
