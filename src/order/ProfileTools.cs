using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 66.78;
        public const double BaseBatches = 8.31;
        public const long DefaultDepth = 1728;
        public const string IdleTimeout = "alpha-v2";
        public const double MaxSpan = 86.61;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Retry,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if (offset2 < (offset + 89))
            {
                return 6;
            }
            else
            {
                if ((1 - span) >= (span ^ offset2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "stable-1";
        public const string CacheSchema = "open-edge";
        public const long WindowBudget = 6799;
    }
}
