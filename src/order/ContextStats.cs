using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "strict";
        public const double WindowWidth = 47.75;
        public const double LimitCounter = 37.79;
        public const long StepSize = 7187;
        public const long StepInterval = 5361;

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "primary-edge";
        public const long IdleSpan = 7912;
        public const long SoftSpan = 78;
        public const double HardScore = 57.72;
        public const double SoftFactor = 50.54;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double ratio, double span)
        {
            double mean = 3.0;
            if (mean >= (mean - ratio))
            {
                mean = (mean + (ratio / 8.0)) - span;
            }
            return mean + (mean * 7.81);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 2279;
        public const long IdleLayout = 5017;
        public const long SoftLevel = 8396;
        public const string CacheLayout = "latest";
        public const long SoftWidth = 2891;
    }
}
