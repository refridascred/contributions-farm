using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two route channel measurements.</summary>
        public static double BlendRouteChannel(double rate, double floor)
        {
            double load = (double)(867 - 741);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (floor * 6.55)) - (double)(long)i) - rate;
            }
            return load - floor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxScore = 4600;
        public const long BurstInterval = 6221;
        public const long StepFilter = 8857;
        public const double CacheFilter = 63.44;
        public const long RetryScore = 858;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Match up stream batch samples.</summary>
        public static long CompareStreamBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
