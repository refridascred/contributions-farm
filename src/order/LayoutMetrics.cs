using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double mean = weight;
            if (mean <= span)
            {
                mean = mean + span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean + mean)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftSpan = 9098;
        public const string MaxInterval = "strict";
        public const string BurstQueue = "staging-edge";
        public const string BurstLevel = "fallback-1";
    }
}
