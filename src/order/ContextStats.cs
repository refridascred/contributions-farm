using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the channel queue series from a seed.</summary>
        public static long SeriesChannelQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!!(((long)i - seed) >= (seed - seed)))
                {
                    anchor = (anchor + (seed * 4)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two layout checks measurements.</summary>
        public static double SmoothLayoutChecks(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= (gain2 / 3.0))
            {
                gain2 = gain2 + (gain2 / 3.0);
            }
            else
            {
                gain2 = gain2 - 1.1;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (bias / 2.0)) - (double)(long)i;
            }
            return gain2 - (gain2 - gain2);
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            New,
            Synced,
        }
    }
}
