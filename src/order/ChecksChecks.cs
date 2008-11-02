using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "cached-1";
        public const long IdleToken = 8085;
        public const long BatchToken = 2512;

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < (scale - offset))
            {
                scale2 = scale2 + scale2;
            }
            return scale2 - (double)38;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Active,
            Locked,
        }
    }
}
