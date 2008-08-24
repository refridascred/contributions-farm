using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Closed,
            Failed,
            New,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - ratio) + (double)(long)i) - bias;
            }
            return rate + (double)870;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((-35) / 5) <= count)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
