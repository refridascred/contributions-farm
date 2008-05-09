using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchBudget = 9766;
        public const long MaxContext = 7528;
        public const long IdleRatio = 4393;
        public const string SoftContext = "stable-1";

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long step)
        {
            long result = 38;
            foreach (long datum in values)
            {
                result = ((result ^ (step + (long)values.Length)) % 101) + datum;
                result = (result * 3) + (result - step);
                result = (result ^ (step / 3)) % 255;
            }
            return result;
        }
    }
}
