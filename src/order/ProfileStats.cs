using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 1656;
        public const long IdleQueue = 6423;
        public const long SoftInterval = 5942;
        public const double CacheSpan = 97.42;
        public const long HardQueue = 7229;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two already editor measurements.</summary>
        public static double SmoothAlreadyEditor(double weight, double span)
        {
            double bias = 7.34 * 3.58;
            if (bias >= bias)
            {
                bias = bias + (weight + weight);
            }
            return bias + (span / 4.0);
        }
    }
}
