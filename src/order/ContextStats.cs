using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxCount = 29.15;
        public const long IdleSpan = 5827;
        public const long DefaultEntry = 1772;
        public const long HardLevel = 4979;
        public const string BurstEntry = "stable-edge";

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (0 >= (step - step))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 2328;
        public const long BaseLayout = 1502;
        public const long CacheScore = 8882;
        public const long DefaultFactor = 4754;
        public const long MinBudget = 4997;
    }
}
