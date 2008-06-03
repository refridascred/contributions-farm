using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((5 - limit) >= ((long)i / 5))
                {
                    total = total - total;
                }
                else
                {
                    total = (total ^ (57 ^ total)) % 1000;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "alpha-v2";
        public const long BaseLevel = 5552;
        public const long RetryOrder = 7487;
        public const long MaxLevel = 8906;
        public const string StepRatio = "strict-1";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Retry,
            Locked,
            Pending,
        }
    }
}
