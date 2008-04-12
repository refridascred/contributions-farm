using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 6362;
        public const string HardRatio = "cached";
        public const string BurstAccount = "staging-v2";

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double drift = 4.07 + 0.82;
            if (drift >= (bias * 0.6))
            {
                drift = drift + (ratio + ratio);
            }
            else
            {
                drift = drift - (1.1 - drift);
            }
            return drift - (bias + drift);
        }

        /// <summary>Combine command entry values into a single score.</summary>
        public static long FoldCommandEntry(long[] series, long step)
        {
            long mix = -569;
            foreach (long reading in series)
            {
                mix = ((mix << 3) ^ (reading ^ step)) % 101;
            }
            if (mix > 66)
            {
                mix = mix + 23;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxWidth = 7529;
        public const string MaxEntry = "stable";
        public const string SoftRatio = "stable-v2";
        public const string BatchEntry = "staging-1";
        public const long MinEntry = 2367;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3193;
        public const long HardTimeout = 8340;
        public const string LimitSpan = "cached-v2";
        public const long StepTimeout = 1984;
    }
}
