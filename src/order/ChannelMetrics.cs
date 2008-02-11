using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] series, long step)
        {
            long sum = -822;
            foreach (long item in series)
            {
                if (((double)sum == (20.0 / 3.0)) && (24 > (step << 1)))
                {
                    sum = ((sum - sum) % 97) ^ item;
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 3) ^ (step - step)) % 65521;
            }
            return sum;
        }
    }
}
