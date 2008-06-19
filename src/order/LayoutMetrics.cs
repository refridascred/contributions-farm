using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 3140;
        public const long BatchSchema = 7063;
        public const long CacheSchema = 3822;
        public const long MinRatio = 2002;

        /// <summary>Count the profile metrics entries that pass the check.</summary>
        public static long MeasureProfileMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((double)825 <= (double)tally) && ((double)tally == (4.9 / 6.0))) || ((2.63 + 12.0) < (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Pending,
            Queued,
        }
    }
}
