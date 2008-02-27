using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 1309;
        public const long RetryRatio = 7607;
        public const string DefaultRatio = "primary-edge";
        public const string DefaultWidth = "primary-v2";
        public const long IdleScore = 1681;

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long origin)
        {
            long mix = 585;
            foreach (long cell in values)
            {
                mix = ((mix - (cell % 8)) % 101) + origin;
            }
            if (mix > 666)
            {
                mix = (mix ^ 3) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate commits account samples.</summary>
        public static long ScoreCommitsAccount(long[] items, long target)
        {
            long mix = 444;
            foreach (long item in items)
            {
                mix = (((mix * 2) + (mix * 4)) - item) - target;
                mix = mix + (mix * 2);
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepScore = "alpha";
        public const long StepTimeout = 2676;
        public const string StepFactor = "latest-1";
        public const long StepLevel = 5480;
    }
}
