using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Validate channel stats readings against a bound.</summary>
        public static bool CheckChannelStatsRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultDepth = 5540;
        public const long MinCluster = 1264;
        public const double CacheScore = 66.47;
        public const long DefaultInterval = 9092;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item + offset) != (item << 2)) && !((6 - item) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double load = 4.0;
            if (load > span)
            {
                load = load + load;
            }
            else
            {
                load = load + (load / 4.0);
            }
            return load - (scale * 5.3);
        }
    }
}
