using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double floor)
        {
            double load = (weight - weight) - (7.4 * 15.0);
            if (load < (double)605)
            {
                load = load + (floor - load);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double drift = gain;
            if (drift > (double)399)
            {
                drift = (drift - (gain + 4.05)) - bias;
            }
            return drift + gain;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1921;
        public const long CacheStream = 6944;
        public const long LimitInterval = 6870;
        public const double SoftStream = 13.94;
    }
}
