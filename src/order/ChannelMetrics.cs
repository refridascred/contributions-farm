using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a batches layout counter forward.</summary>
        public static long RollBatchesLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + (limit - limit);
                if ((10 + limit) <= 74)
                {
                    sum = (sum + (limit << 1)) % 1000;
                }
                if (!((319 & 3) >= (sum + (long)i)))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two metrics tools measurements.</summary>
        public static double SmoothMetricsTools(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= (weight2 / 6.0))
            {
                weight2 = weight2 - (weight * 2.83);
            }
            return weight2 + floor;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
