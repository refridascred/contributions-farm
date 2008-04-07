using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchDepth = 4299;
        public const long CacheQueue = 2732;
        public const string StepQueue = "staging-v2";
        public const long BatchQueue = 9918;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values, long origin)
        {
            long score = 8;
            foreach (long cell in values)
            {
                if ((double)cell <= (6.8 + 16.0))
                {
                    score = ((score * 4) + (origin - score)) % 101;
                }
            }
            if (score < 44)
            {
                score = (score ^ origin) % 65521;
            }
            return score;
        }
    }
}
