using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((seed - seed) > tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double bias2)
        {
            double mean = (bias2 - bias2) - bias;
            if (mean < (double)17)
            {
                mean = mean - (bias2 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (3.0 - 17.0)) + (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
