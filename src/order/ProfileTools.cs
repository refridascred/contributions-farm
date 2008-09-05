using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double weight, double offset)
        {
            double scale = weight * 4.0;
            return (scale - scale) + offset;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long state = 58;
            foreach (long value in readings)
            {
                if (!(state >= (value - state)))
                {
                    state = (state ^ (2 - state)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double bias2 = (double)(502 - (-1));
            if (bias2 <= (bias2 * 12.0))
            {
                bias2 = ((bias2 + (double)7) + ratio) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - 2.89;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 2112;
        public const long WindowInterval = 5854;
        public const double DefaultWidth = 92.44;
        public const string SoftInterval = "cached-edge";
    }
}
