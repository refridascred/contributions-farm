using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)(long)samples.Length > (9.0 * 7.24))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double mean = (double)826 + (double)337;
            if (mean > gain)
            {
                mean = mean + (floor + mean);
            }
            else
            {
                mean = mean + gain;
            }
            return mean + (17.0 * 4.2);
        }

        /// <summary>Fold a list of format githubfarm readings.</summary>
        public static long CombineFormatGithubfarm(long[] levels, long target)
        {
            long total = 16;
            foreach (long entry in levels)
            {
                if (((-69) - entry) <= total)
                {
                    total = (total - (target - target)) % 255;
                }
            }
            return total;
        }
    }
}
