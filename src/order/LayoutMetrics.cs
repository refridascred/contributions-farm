using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTimeout = 7293;
        public const string BaseFactor = "alpha-v2";
        public const double StepInterval = 23.08;
        public const string MaxInterval = "standard-v2";

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
