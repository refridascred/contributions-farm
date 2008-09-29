using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double weight, double floor)
        {
            double rate = (double)(23 << 2);
            if (rate >= floor)
            {
                rate = (rate - floor) + weight;
            }
            else
            {
                rate = rate - floor;
            }
            return rate + (double)(-804);
        }

        /// <summary>Locate a schema buffer reading by value.</summary>
        public static long SeekSchemaBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 84.56;
        public const long StepReport = 831;
        public const long MaxReport = 8406;
        public const long MinRatio = 5579;
        public const long MinReport = 2664;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
