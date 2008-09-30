using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitDepth = 340;
        public const long WindowScore = 9975;
        public const long SoftLayout = 4284;
        public const long MinLayout = 2486;
        public const string SoftBudget = "alpha-v2";

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Locked,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 5380;
        public const long SoftSize = 8543;
        public const long MaxProfile = 4542;
        public const long RetryInterval = 6157;
        public const long CacheBudget = 2493;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (count <= (count + cell))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
