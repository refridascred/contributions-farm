using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series)
        {
            long score = 5;
            foreach (long cell in series)
            {
                score = ((score ^ (score & 63)) % 255) ^ cell;
            }
            if (score < (-451))
            {
                score = score ^ (280 * 3);
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultDepth = 5691;
        public const string CacheOrder = "alpha";
        public const long StepCount = 4583;
        public const double IdleOrder = 68.86;

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitDepth = 1599;
        public const long BurstStream = 9062;
        public const long BurstBudget = 1121;
        public const long MaxLevel = 3569;
        public const string MaxStream = "latest-edge";
    }
}
