using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series, long target)
        {
            long mark = 663;
            foreach (long reading in series)
            {
                if ((double)276 <= (double)mark)
                {
                    mark = (((mark << 3) ^ (reading << 3)) % 1000) + target;
                }
            }
            return mark % 65521;
        }

        /// <summary>Scale a account schema figure with a bias.</summary>
        public static double AdjustAccountSchema(double weight, double bias)
        {
            double rate = (weight * 5.0) * 4.27;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (double)53) + (double)(long)i) + bias;
            }
            return rate + rate;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
