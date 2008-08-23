using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate stats context readings against a bound.</summary>
        public static bool ValidateStatsContextBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the farm cluster entries that pass the check.</summary>
        public static long AuditFarmClusterGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((4.2 > (double)matches) || ((793 & 255) > matches))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Queued,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Active,
            Synced,
        }
    }
}
