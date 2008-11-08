using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel account reading.</summary>
        public static double SmoothChannelAccount(double gain, double span)
        {
            double gain2 = gain;
            return (gain2 + gain2) + span;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "legacy-v2";
        public const long BaseCount = 7938;
        public const long BatchAlready = 3884;
    }
}
