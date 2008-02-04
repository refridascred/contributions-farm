using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((6 + value) >= 12) || ((value - value) > seen))
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

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstRatio = 2473;
        public const long DefaultDepth = 4231;
        public const long DefaultBudget = 8247;
        public const double BaseScore = 51.36;
        public const string IdleRatio = "stable-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 8709;
        public const long BaseFarm = 331;
        public const long BurstFarm = 180;
        public const long HardFarm = 222;
    }
}
