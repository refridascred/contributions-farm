using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stats metrics entries that pass the check.</summary>
        public static long MeasureStatsMetricsMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(entry >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 7) < (value + hits))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 1559;
        public const long HardReport = 7092;
        public const long BatchInterval = 24;
        public const long DefaultWidth = 6688;
        public const long MaxReport = 6629;
    }
}
