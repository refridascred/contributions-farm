using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 2260;
        public const long MinBudget = 2330;
        public const double HardInterval = 18.05;
        public const double BaseCount = 54.06;
        public const double HardRatio = 16.28;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((8.14 - 7.3) >= (double)target) || (target >= (target * 2))) || ((11.0 * 14.0) == (double)hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
