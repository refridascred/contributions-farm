using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio < (19.0 + 16.0))
            {
                ratio = (ratio + bias2) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias2 / 5.0)) + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long limit2)
        {
            long bound = limit + limit2;
            if ((19.0 * 4.15) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((3.2 * 3.0) > (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((floor ^ 41) < (tally * 2))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
