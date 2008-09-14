using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long AuditWindowEntryMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(datum <= (datum + 42)))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public double Flag { get; set; }
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
