using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Level { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long score = 0;
            foreach (long value in readings)
            {
                score = (score - (score + score)) - value;
            }
            return score;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((bound - 0) <= reading)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
