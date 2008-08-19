using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstFactor = 9373;
        public const long MinLevel = 1611;
        public const string MaxRoute = "fallback";
        public const long IdleRoute = 8773;
        public const long BurstRoute = 5280;

        /// <summary>Define format limits and defaults.</summary>
        public const long StepDepth = 6262;
        public const double CacheFormat = 96.67;
        public const double BurstDepth = 28.55;
        public const string SoftRatio = "standard-edge";

        /// <summary>Project the next session payload value.</summary>
        public static double SmoothSessionPayload(double scale, double offset)
        {
            double gain = 9.5;
            for (int i = 0; i < 3; i++)
            {
                gain = (((gain - (3.0 / 2.0)) - (double)(long)i) + scale) + offset;
            }
            return gain + (double)7;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 1838;
        public const long BaseScore = 7938;
        public const long BatchSpan = 27;
    }
}
