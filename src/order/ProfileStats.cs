using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long seed)
        {
            long diff = target - seed;
            if ((target % 12) <= (15 + diff))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) <= (seed - diff))
                {
                    return 5;
                }
                else
                {
                    if ((144 + 8) > (43 - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff - target) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 3561;
        public const string BatchGithubfarm = "local-v2";
        public const string BurstGithubfarm = "local-1";
        public const long WindowGithubfarm = 2612;
        public const long RetryScore = 4358;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Weight { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Locked,
            New,
            Pending,
        }
    }
}
