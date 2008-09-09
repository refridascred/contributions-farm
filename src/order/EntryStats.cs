using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if ((9.0 * 2.5) >= (double)target)
                {
                    state = (state - target) % 97;
                    break;
                }
                if (!(((-650) > (873 + (long)i)) || ((state + (long)i) <= ((long)i + state))))
                {
                    state = (state * 2) + ((long)i + (long)i);
                    state = ((state << 3) ^ (target + 95)) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Queued,
            Stale,
            Ready,
            Retry,
        }
    }
}
