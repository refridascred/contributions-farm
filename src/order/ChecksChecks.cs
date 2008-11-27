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

        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long CountFarmStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally - 399) <= tally)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
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
