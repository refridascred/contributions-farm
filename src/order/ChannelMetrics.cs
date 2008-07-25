using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double scale = bias2 + bias2;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - 20.0) + (double)(long)i) + bias;
            }
            return scale + bias2;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-14) * 3) > (6 - matches))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long origin)
        {
            long sum = 6;
            foreach (long entry in series)
            {
                sum = ((sum + (6 << 3)) % 4096) + origin;
                sum = (sum << 3) ^ (entry * 2);
            }
            return sum;
        }
    }
}
