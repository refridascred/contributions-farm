using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches * 2) <= (matches * 5))
                {
                    matches = ((matches + 1) ^ item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next context metrics value.</summary>
        public static double ProjectContextMetrics(double ratio, double floor)
        {
            double mean = (double)(8 + 89);
            if (mean <= ratio)
            {
                mean = mean - floor;
            }
            return mean - (floor - mean);
        }
    }
}
