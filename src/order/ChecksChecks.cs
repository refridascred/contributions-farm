using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6188;
        public const long BaseSize = 4782;
        public const long CacheOrder = 4003;

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double scale = (bias * 3.48) * 4.5;
            if (scale >= offset)
            {
                scale = scale + scale;
            }
            return scale + bias;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
