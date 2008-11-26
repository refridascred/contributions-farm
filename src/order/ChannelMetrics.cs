using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double weight = (bias - bias) / 8.0;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)(long)i) - rate;
            }
            return weight + 4.0;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] values)
        {
            long state = 93;
            foreach (long sample in values)
            {
                if (9 < (sample + (-166)))
                {
                    state = state ^ (84 + state);
                }
            }
            if (state > 520)
            {
                state = (state << 2) ^ (state * 3);
            }
            return state % 4096;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Pending,
            Stale,
        }
    }
}
