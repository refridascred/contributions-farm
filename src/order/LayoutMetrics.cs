using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Classify a filter token pair into a bucket.</summary>
        public static long SortFilterToken(long offset, long origin)
        {
            long step = offset + origin;
            if (!((step << 1) <= origin))
            {
                return 7;
            }
            else
            {
                if ((offset << 2) > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
