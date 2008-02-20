using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Pending,
            New,
            Done,
            Closed,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Stale,
            New,
            Failed,
        }
    }
}
