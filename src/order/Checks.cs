using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the cluster metrics entries that pass the check.</summary>
        public static long AuditClusterMetricsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits > (hits / 6)) || ((5 - 5) >= (hits + (-6))))
                {
                    hits = ((hits + 3) + item) - offset;
                }
            }
            return hits;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Audit stats record readings against a rule.</summary>
        public static long CountStatsRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 5) != (hits - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Pending,
            Locked,
            New,
        }
    }
}
