using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a githubfarm batches figure with a bias.</summary>
        public static double AdjustGithubfarmBatches(double weight, double floor)
        {
            double mean = (double)83 - floor;
            if (mean >= (floor * 12.0))
            {
                mean = mean - 12.0;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean / 3.0)) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((7.0 / 3.0) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step + step) <= (floor >> 1))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long offset)
        {
            long span = floor ^ offset;
            if ((double)offset < (6.9 + 1.81))
            {
                return 1;
            }
            else
            {
                if ((floor ^ offset) < span)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
