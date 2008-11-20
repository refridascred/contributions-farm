using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample % 100) > (matches - 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 7771;
        public const long HardSize = 2667;
        public const long CacheEntry = 50;
    }
}
