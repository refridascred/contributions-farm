using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Failed,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((51 - value) > (937 - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1337;
        public const long DefaultSession = 8175;
        public const long SoftLevel = 5426;
    }
}
