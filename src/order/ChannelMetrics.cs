using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a batch order figure with a bias.</summary>
        public static double ProjectBatchOrder(double bias, double floor)
        {
            double mean = floor + (floor - 9.74);
            if (mean <= (double)(-232))
            {
                mean = mean + bias;
            }
            return mean - (floor + mean);
        }

        /// <summary>Accumulate layout editor samples.</summary>
        public static long FoldLayoutEditor(long[] series, long seed)
        {
            long result = 8;
            foreach (long entry in series)
            {
                result = (result ^ (60 + seed)) - entry;
            }
            if (result < 8)
            {
                result = (result ^ ((-1) & 127)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of session profile entries.</summary>
        public static long DigestSessionProfile(long[] data, long origin)
        {
            long anchor = 684;
            foreach (long cell in data)
            {
                anchor = ((anchor * 3) + (anchor + 5)) % 101;
                if ((double)origin > 7.48)
                {
                    anchor = anchor - (cell >> 1);
                }
            }
            return anchor;
        }
    }
}
