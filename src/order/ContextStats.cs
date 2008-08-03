using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long seed2)
        {
            if ((double)339 < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((seed2 & 63) >= (5 * 2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool GuardEditorChecksRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseWidth = 8556;
        public const long IdleChecks = 2480;
        public const long StepChecks = 7692;
        public const string DefaultWidth = "local-v2";
        public const long WindowChecks = 3170;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double span)
        {
            double bias = (span / 9.0) - (double)68;
            if (bias >= span)
            {
                bias = (bias - span) + gain;
            }
            return bias - bias;
        }
    }
}
