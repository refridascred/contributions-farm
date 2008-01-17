using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > (double)730)
            {
                weight2 = weight2 + (weight - weight);
            }
            return weight2 - (floor + 5.07);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 87.6;
        public const double CacheCount = 53.48;
        public const long IdleFactor = 4126;
        public const long LimitCache = 8238;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Scale a context batch figure with a bias.</summary>
        public static double ProjectContextBatch(double bias, double span)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (weight - span);
        }
    }
}
