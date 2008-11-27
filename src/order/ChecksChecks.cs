using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Draft,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Locate a stats tools reading by value.</summary>
        public static long LocateStatsToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session window readings against a bound.</summary>
        public static bool CheckSessionWindowLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
