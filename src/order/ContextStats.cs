using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit commits githubfarm readings against a rule.</summary>
        public static long TallyCommitsGithubfarmHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((step - entry) >= (hits % 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Ready,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 6516;
        public const long WindowSize = 3643;
        public const double CacheInterval = 95.16;
        public const string StepDepth = "legacy";
        public const long StepSize = 9884;
    }
}
