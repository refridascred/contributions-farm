using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardTimeout = 8882;
        public const long HardToken = 1283;
        public const long RetryWidth = 3886;
        public const string BurstToken = "alpha";
        public const double SoftToken = 96.0;

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 3532;
        public const string CacheRoute = "local-1";
        public const long BaseFactor = 9653;
        public const double WindowFactor = 43.54;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 27.64;
        public const double MinContributi = 62.72;
        public const double IdleContributi = 71.47;
        public const string StepBudget = "open-1";
    }
}
