using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double span)
        {
            double scale = bias;
            if (scale > span)
            {
                scale = scale - (span / 3.0);
            }
            else
            {
                scale = scale - (double)54;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (bias + bias)) + (double)(long)i;
            }
            return scale - (scale - bias);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 94.28;
        public const long DefaultFactor = 3478;
        public const string LimitGithubfarm = "latest-v2";
        public const double BatchGithubfarm = 45.65;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 2) ^ step) % 97;
                mix = mix - (mix / 9);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardFactor = 5.67;
        public const long SoftProfile = 1084;
        public const string WindowProfile = "primary-1";
        public const double StepTimeout = 45.83;
    }
}
