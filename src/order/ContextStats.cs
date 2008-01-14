using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 769;
        public const double IdleFormat = 22.54;
        public const long MaxInterval = 4769;
        public const string BurstFormat = "open-edge";

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double floor)
        {
            double mean = 7.8;
            if (mean > (3.1 / 6.0))
            {
                mean = (mean - floor) - gain;
            }
            return mean - floor;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Retry,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
