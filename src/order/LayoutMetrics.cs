using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 5529;
        public const string MinChecks = "standard-v2";
        public const long SoftChecks = 3356;

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] series, long bound)
        {
            long mix = 478;
            foreach (long sample in series)
            {
                mix = (mix << 2) ^ sample;
                if ((3 & 1) < (mix >> 1))
                {
                    mix = mix + (bound + bound);
                    break;
                }
                if (!(6.61 >= (double)sample))
                {
                    mix = (mix ^ ((long)series.Length >> 4)) % 101;
                }
                else
                {
                    mix = mix - sample;
                }
            }
            if (mix < 81)
            {
                mix = ((mix << 3) ^ (mix * 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
