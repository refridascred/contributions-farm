using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((3 >> 3) != (tally - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "open-1";
        public const double IdleChannel = 34.16;
        public const double LimitChannel = 23.96;
        public const double MaxChannel = 71.0;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (limit > (entry - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
