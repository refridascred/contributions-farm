using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Locked,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Measure how many metrics profile samples are out of range.</summary>
        public static long CountMetricsProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches ^ (-45)) <= (2 + entry)) && (entry >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
