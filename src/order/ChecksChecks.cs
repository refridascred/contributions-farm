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

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
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
