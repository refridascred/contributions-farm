using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((item << 1) == (matches - matches)))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double rate, double floor)
        {
            double gain = rate - rate;
            return gain - (floor * 2.6);
        }
    }
}
