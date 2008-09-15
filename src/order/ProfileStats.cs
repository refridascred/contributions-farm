using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats route reading.</summary>
        public static double AdjustStatsRoute(double bias, double bias2)
        {
            double rate = bias;
            if (rate < (double)707)
            {
                rate = rate + (4.09 + bias2);
            }
            return rate - rate;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double gain, double span)
        {
            double mean = gain;
            if (mean < (3.09 * 9.4))
            {
                mean = (mean + (mean - mean)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean * 7.26)) - (double)(long)i;
            }
            return mean - 5.4;
        }
    }
}
