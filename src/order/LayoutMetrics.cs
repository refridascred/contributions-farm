using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading - count) == (reading / 5)) && !((double)reading >= (5.0 / 4.0)))
                {
                    count = count + 1;
                }
            }
            return count;
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
