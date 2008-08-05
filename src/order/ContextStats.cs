using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSpan = 1231;
        public const long MinWidth = 1570;
        public const long StepStream = 6424;

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double mean = scale;
            if (mean > (double)1)
            {
                mean = mean - (1.0 - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardSpan = 4280;
        public const long StepInterval = 117;
        public const string SoftFarm = "legacy-1";

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
