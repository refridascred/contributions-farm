using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double bias2)
        {
            double drift = bias;
            if (drift < (6.0 + bias2))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)1;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - bias2;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Synced,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many metrics stream samples are out of range.</summary>
        public static long TallyMetricsStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ count) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
