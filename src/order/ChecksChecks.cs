using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = 64;
            foreach (long item in values)
            {
                if (!(mark >= (item & 1)))
                {
                    mark = mark - mark;
                }
                if ((double)mark == (9.9 / 2.0))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double mean = (rate - 20.0) / 3.0;
            if (mean <= (mean / 7.0))
            {
                mean = mean + (span * 16.0);
            }
            return mean + rate;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double floor)
        {
            double weight = floor;
            return (weight + (floor * 9.0)) + rate;
        }
    }
}
