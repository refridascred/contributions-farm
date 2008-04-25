using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Paused,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels)
        {
            long mix = 149;
            foreach (long reading in levels)
            {
                mix = (mix << 2) ^ (36 + reading);
            }
            return mix % 97;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
