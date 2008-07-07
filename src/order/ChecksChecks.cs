using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (20.0 * 1.36))
            {
                ratio = ratio + (scale + 19.0);
            }
            else
            {
                ratio = ratio + (double)1;
            }
            return ratio + (13.0 - offset);
        }

        /// <summary>Derive the next cache report value from a seed.</summary>
        public static long IterateCacheReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((acc - (long)i) != (acc + limit))
                {
                    acc = (acc * 5) + (limit % 16);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 4779;
        public const string DefaultStream = "staging-1";
        public const double MaxScore = 75.96;
        public const double StepStream = 19.45;
    }
}
