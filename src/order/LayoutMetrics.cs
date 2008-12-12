using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Pending,
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long result = 48;
            foreach (long item in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result * 5) + item) % 65521) + (long)i;
                }
                result = (result + (long)levels.Length) % 255;
                if ((0.7 - 8.4) > (double)result)
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = ((result * 3) + seed) % 4096;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchBudget = 88.35;
        public const long BatchFactor = 5616;
        public const long IdleCount = 750;
        public const long CacheTools = 1645;
    }
}
