using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Synced,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading > (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Stale,
            Synced,
            Pending,
            New,
        }
    }
}
