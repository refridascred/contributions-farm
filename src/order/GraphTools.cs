using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Draft,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (long)i) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
