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

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
