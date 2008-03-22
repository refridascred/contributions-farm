using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double rate = floor + (ratio + ratio);
            if (rate <= (double)72)
            {
                rate = rate + ratio;
            }
            return rate - floor;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (scale / 3.0))
            {
                mean = mean - (double)(-41);
            }
            else
            {
                mean = mean + (bias - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Draft,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
