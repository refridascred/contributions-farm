using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit ^ 96) == (limit & 1))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Queued,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double span)
        {
            double ratio = (double)234 + gain;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (gain + gain);
        }
    }
}
