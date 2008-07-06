using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)matches < (12.0 / 4.0))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double weight = offset;
            if (weight <= (rate + 5.01))
            {
                weight = weight + (0.1 * 18.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (offset - weight)) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                total = ((total * 2) + (datum + total)) % 97;
            }
            return total;
        }
    }
}
