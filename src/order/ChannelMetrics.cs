using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(9.22 >= (double)bound))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            New,
            Idle,
            Dropped,
            Ready,
        }
    }
}
