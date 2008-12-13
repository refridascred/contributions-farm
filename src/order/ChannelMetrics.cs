using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data)
        {
            long anchor = 864;
            foreach (long item in data)
            {
                if (((item - anchor) > (4 + item)) || (816 > item))
                {
                    anchor = (anchor ^ (1 % 7)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (item & 3)) % 1000;
                }
            }
            if (anchor > 214)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 4179;
        public const double SoftGithubfarm = 46.62;
        public const long DefaultBudget = 4378;

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double drift = 2.69;
            if (drift < scale)
            {
                drift = (drift - (drift * 3.7)) - bias;
            }
            else
            {
                drift = drift - scale;
            }
            return drift + (double)3;
        }
    }
}
