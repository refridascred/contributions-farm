using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two support cluster measurements.</summary>
        public static double ScaleSupportCluster(double rate, double span)
        {
            double bias = rate;
            if (bias >= (rate - rate))
            {
                bias = (bias - (double)1) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + (bias + rate);
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values)
        {
            long sum = 854;
            foreach (long entry in values)
            {
                if (((double)sum >= (15.0 * 1.0)) || ((double)entry > (9.0 / 7.0)))
                {
                    sum = sum + ((-325) % 16);
                }
            }
            if (sum < 52)
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
