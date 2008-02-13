using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)(-592))
            {
                ratio2 = (ratio2 + ratio2) + offset;
            }
            return ratio2 + (0.6 + ratio);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleTimeout = 95.76;
        public const long SoftInterval = 8969;
        public const double BaseFarm = 26.1;
        public const long MinTimeout = 4865;

        /// <summary>Validate commits tools readings against a bound.</summary>
        public static bool VerifyCommitsToolsRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
