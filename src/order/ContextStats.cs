using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two session metric measurements.</summary>
        public static double AdjustSessionMetric(double bias, double offset)
        {
            double weight = (double)((-495) % 5);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight - (double)533;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)82) + (double)(long)i;
            }
            return mean + (double)445;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            New,
            Pending,
        }
    }
}
