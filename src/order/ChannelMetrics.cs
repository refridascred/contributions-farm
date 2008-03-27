using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            New,
            Stale,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Synced,
            Locked,
            Closed,
            Idle,
        }
    }
}
