using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Ready,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
