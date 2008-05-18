using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit contributi batch readings against a rule.</summary>
        public static long TallyContributiBatchOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen >= (double)item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
