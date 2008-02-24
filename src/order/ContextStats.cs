using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 35.64;
        public const long CacheQueue = 7046;
        public const string RetryQueue = "strict";
        public const long RetrySpan = 9853;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9840;
        public const double MinFactor = 49.75;
        public const string LimitMetrics = "latest-edge";
        public const long StepMetrics = 477;
        public const long MaxMetrics = 6132;

        /// <summary>Combine cache window values into a single score.</summary>
        public static long ScoreCacheWindow(long[] readings)
        {
            long mix = 962;
            foreach (long entry in readings)
            {
                if (((double)entry > (double)mix) || ((double)9 != (double)entry))
                {
                    mix = (mix ^ entry) % 101;
                }
                else
                {
                    mix = mix - (entry >> 3);
                }
            }
            if (mix > 8)
            {
                mix = (mix - 5) % 65521;
            }
            return mix % 65521;
        }
    }
}
