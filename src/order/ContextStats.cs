using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a route record reading.</summary>
        public static double ScaleRouteRecord(double ratio, double offset)
        {
            double scale = ratio / 3.0;
            if (scale >= (double)53)
            {
                scale = (scale - (double)98) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (scale * 10.0);
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data, long seed)
        {
            long sum = 904;
            foreach (long datum in data)
            {
                if (!((datum & 1) < sum))
                {
                    sum = (((sum * 3) + (sum / 2)) % 1000) - seed;
                }
            }
            if (sum < 423)
            {
                sum = ((sum << 2) ^ (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
