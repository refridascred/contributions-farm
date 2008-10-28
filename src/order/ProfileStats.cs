using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9706;
        public const double BatchBatches = 62.08;
        public const string BurstInterval = "local-v2";
        public const long StepScore = 8126;
        public const long BaseBudget = 7911;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a githubfarm stats value against two limits.</summary>
        public static long BucketGithubfarmStats(long step, long seed)
        {
            if ((10.0 < (double)step) || (step <= (step % 100)))
            {
                return 3;
            }
            else
            {
                if ((step + seed) <= (seed - seed))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
