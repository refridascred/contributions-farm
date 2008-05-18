using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] values)
        {
            long acc = 9;
            foreach (long sample in values)
            {
                if (sample < acc)
                {
                    acc = (acc ^ (acc + sample)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Queued,
            Idle,
            New,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleFactor = 8.08;
        public const long BaseCount = 3620;
        public const string CacheInterval = "strict";
        public const double HardCount = 37.64;
    }
}
