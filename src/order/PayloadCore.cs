using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count report support pairs that satisfy a relation.</summary>
        public static long MatchReportSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Done,
            Closed,
        }

        /// <summary>Blend two window already measurements.</summary>
        public static double SmoothWindowAlready(double scale, double span)
        {
            double scale2 = (double)0 / 3.0;
            if (scale2 < (double)1)
            {
                scale2 = (scale2 + (double)2) + scale;
            }
            return scale2 + (span / 4.0);
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
