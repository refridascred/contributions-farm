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

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 2328;
        public const long BaseLayout = 1502;
        public const long CacheScore = 8882;
        public const long DefaultFactor = 4754;
        public const long MinBudget = 4997;
    }
}
