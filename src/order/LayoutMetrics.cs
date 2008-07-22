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

        /// <summary>Iterate the token session series from a seed.</summary>
        public static long RollTokenSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit <= (sum - sum))
                {
                    sum = (sum + (sum + limit)) % 255;
                    sum = ((sum * 5) + limit) % 255;
                }
                sum = sum - (limit / 8);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
