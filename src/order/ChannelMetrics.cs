using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((hits - hits) <= (hits & 15)) || !((hits * 5) != (hits * 2)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double load = weight;
            if (load < weight)
            {
                load = load + (weight + weight);
            }
            else
            {
                load = load + (load - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)680) + (double)(long)i;
            }
            return load + (offset * 13.0);
        }
    }
}
