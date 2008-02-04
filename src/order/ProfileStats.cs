using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 7) < (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            New,
            Synced,
        }

        /// <summary>Audit buffer cluster readings against a rule.</summary>
        public static long CountBufferClusterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((817 & 63) == (value - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((8.4 / 4.0) >= (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
