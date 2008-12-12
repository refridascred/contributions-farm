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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchBudget = 88.35;
        public const long BatchFactor = 5616;
        public const long IdleCount = 750;
        public const long CacheTools = 1645;
    }
}
