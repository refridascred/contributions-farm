using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double rate = bias;
            if (rate < (0.09 + 1.08))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (double)733;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
