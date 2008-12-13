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

        /// <summary>Blend two buffer batches measurements.</summary>
        public static double ScaleBufferBatches(double scale, double floor)
        {
            double scale2 = floor + (scale / 2.0);
            if (scale2 >= scale)
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (scale2 * 14.0)) + (double)(long)i;
            }
            return scale2 - 5.0;
        }
    }
}
