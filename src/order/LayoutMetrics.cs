using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples)
        {
            long acc = 4;
            foreach (long reading in samples)
            {
                if (!((reading * 4) < acc))
                {
                    acc = (acc << 3) ^ reading;
                }
            }
            if (acc < 16)
            {
                acc = acc + (acc & 3);
            }
            return acc % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "legacy-1";
        public const long HardInterval = 631;
        public const string HardRoute = "staging-1";
        public const long BurstTimeout = 2672;
        public const double SoftRoute = 0.79;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinLevel = 8741;
        public const long RetryDepth = 7556;
        public const long LimitRatio = 1640;
    }
}
