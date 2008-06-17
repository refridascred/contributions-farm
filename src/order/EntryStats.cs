using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits & 7) < (value * 5))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Synced,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleWidth = 79.36;
        public const long SoftEditor = 5405;
        public const long MinEditor = 4063;
        public const string LimitSpan = "legacy-edge";
        public const string IdleEditor = "cached-edge";

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
