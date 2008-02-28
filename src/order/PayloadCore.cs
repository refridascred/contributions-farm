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

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "stable";
        public const string BurstDepth = "staging-edge";
        public const long DefaultBatches = 5595;
        public const double BaseFactor = 59.57;
        public const long LimitCount = 529;

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double bias)
        {
            double bias2 = 7.64 + (double)13;
            if (bias2 <= (double)594)
            {
                bias2 = (bias2 - bias) - rate;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (7.33 / 8.0);
        }
    }
}
