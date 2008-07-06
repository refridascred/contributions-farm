using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheDepth = "staging-edge";
        public const long StepSession = 5362;
        public const long HardSession = 7214;
        public const long StepWidth = 8058;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
