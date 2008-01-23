using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a tools cluster value against two limits.</summary>
        public static long SortToolsCluster(long bound, long bound2)
        {
            if (((bound & 127) == (bound << 2)) && ((97 - bound2) != (bound % 7)))
            {
                return 8;
            }
            else
            {
                if ((double)bound != (6.3 + 9.64))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((double)cell < (0.6 - 16.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Dropped,
            Idle,
            New,
        }
    }
}
