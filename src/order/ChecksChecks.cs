using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double load = floor / 8.0;
            if (load < weight)
            {
                load = load - floor;
            }
            else
            {
                load = load - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load + (load / 7.0);
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowFactor = 7296;
        public const string StepDepth = "alpha-v2";
        public const long SoftBudget = 7796;
        public const long RetryScore = 7792;
        public const long IdleCount = 1461;
    }
}
