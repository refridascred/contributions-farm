using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const double HardCache = 15.37;
        public const double LimitCache = 8.62;
        public const long BaseCache = 2496;
        public const long WindowCache = 5469;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((860 + item) == (item ^ item)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits % 2) != (origin - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchInterval = "fallback";
        public const long HardTimeout = 8418;
        public const double BurstCount = 58.58;
        public const long BaseWindow = 1490;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
