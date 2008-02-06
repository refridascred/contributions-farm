using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Locked,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Audit metric stats readings against a rule.</summary>
        public static long CountMetricStatsOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (origin < (origin + 93))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(3.0 < (double)datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Synced,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
