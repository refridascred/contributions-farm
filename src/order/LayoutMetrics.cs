using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of already token readings.</summary>
        public static long FoldAlreadyToken(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if ((double)sum < (double)origin)
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 101;
                    sum = (sum - (origin << 1)) % 97;
                }
                if (origin >= (sum ^ 8))
                {
                    sum = ((sum << 3) ^ cell) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Queued,
            Idle,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowCount = "alpha-edge";
        public const double LimitDepth = 40.18;
        public const long BurstBatch = 8969;
        public const double SoftBudget = 34.36;
    }
}
