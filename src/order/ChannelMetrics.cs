using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Draft,
            Retry,
            Failed,
            Active,
        }
    }
}
