using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitDepth = 7191;
        public const long IdleCommand = 8917;
        public const double BaseCommand = 33.7;

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
