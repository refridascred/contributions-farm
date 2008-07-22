using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 13.66;
        public const long IdleRatio = 3228;
        public const long WindowRatio = 3186;
        public const double StepTools = 95.03;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
