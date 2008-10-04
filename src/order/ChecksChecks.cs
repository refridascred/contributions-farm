using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= (matches + matches))
                {
                    matches = ((matches + 3) + reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Draft,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
