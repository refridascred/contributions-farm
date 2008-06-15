using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 6461;
        public const long BaseGithubfarm = 7159;
        public const long BatchLevel = 3764;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Locked,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Queued,
            Closed,
            Pending,
            Active,
        }
    }
}
