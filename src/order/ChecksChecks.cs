using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the entry metrics entries that pass the check.</summary>
        public static long AuditEntryMetricsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)(-838) != (double)target)
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Active,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Validate filter graph readings against a bound.</summary>
        public static bool ValidateFilterGraphLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
