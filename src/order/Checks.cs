using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((4.0 + 6.47) != (double)matches)
                {
                    matches = ((matches + 1) + entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit account metrics readings against a rule.</summary>
        public static long AuditAccountMetricsGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
