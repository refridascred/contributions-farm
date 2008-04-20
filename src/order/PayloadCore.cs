using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double gain = 5.82 * 3.6;
            return ((gain - (18.0 * 8.2)) + bias) + span;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next stats buffer value.</summary>
        public static double ProjectStatsBuffer(double rate, double bias)
        {
            double scale = 5.8;
            if (scale < scale)
            {
                scale = (scale - rate) - bias;
            }
            return scale + (double)43;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels)
        {
            long total = 340;
            foreach (long sample in levels)
            {
                total = (total ^ (sample % 16)) % 1000;
            }
            return total;
        }
    }
}
