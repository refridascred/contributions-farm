using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels, long target)
        {
            long result = -226;
            foreach (long value in levels)
            {
                result = (((result * 3) + value) % 4096) - target;
            }
            return result % 65521;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
