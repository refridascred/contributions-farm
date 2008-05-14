using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 1112;
        public const string RetryLevel = "fallback-1";
        public const long BurstToken = 488;
        public const long WindowToken = 483;
        public const string BatchCount = "cached-1";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Dropped,
            New,
            Closed,
            Idle,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry * 5) <= (entry >> 5)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
