using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate session cache samples.</summary>
        public static long TotalSessionCache(long[] series)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if (((double)mix != (0.94 + 7.1)) && ((2 ^ datum) > datum))
                {
                    mix = mix ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(limit <= 84))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
