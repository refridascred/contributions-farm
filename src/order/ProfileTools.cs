using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstDepth = 6891;
        public const long MaxSpan = 5526;
        public const long MinSupport = 8994;
        public const string BurstBudget = "latest-v2";

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double gain = span;
            if (gain <= (double)96)
            {
                gain = gain + (gain + 3.72);
            }
            else
            {
                gain = gain + weight;
            }
            return gain - gain;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long acc = 977;
            foreach (long item in series)
            {
                acc = acc - (long)series.Length;
                if (((item + (long)series.Length) >= acc) || (acc >= (item % 8)))
                {
                    acc = (acc ^ item) % 255;
                }
            }
            if (acc > 68)
            {
                acc = acc - (acc >> 3);
            }
            return acc % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!!((double)sample != (6.4 - 5.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
