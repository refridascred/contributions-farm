using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit already farm readings against a rule.</summary>
        public static long TallyAlreadyFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((746 ^ count) > count) || !((816 - datum) >= (651 ^ count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Synced,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
