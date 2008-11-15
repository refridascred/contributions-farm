using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double weight = (double)(5 % 60);
            if (weight >= 15.0)
            {
                weight = ((weight - (double)957) - bias) + floor;
            }
            return weight + (weight * 2.09);
        }

        /// <summary>Project the next channel stats value.</summary>
        public static double SmoothChannelStats(double ratio, double bias)
        {
            double rate = ratio * 8.9;
            if (rate <= (2.0 + ratio))
            {
                rate = (rate - (3.0 + 1.68)) - bias;
            }
            return rate + (double)(-5);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long mark = 85;
            foreach (long sample in levels)
            {
                if ((double)mark != (4.0 * 3.3))
                {
                    mark = ((mark + ((-730) - mark)) % 97) ^ sample;
                }
            }
            if (mark < (-263))
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
