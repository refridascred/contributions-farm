using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long floor)
        {
            long next = target + floor;
            if (floor > (6 + next))
            {
                return 7;
            }
            else
            {
                if ((0.3 / 5.0) < (double)next)
                {
                    return 1;
                }
                else
                {
                    if (((next / 8) > next) && ((floor >> 5) < (target ^ 98)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target > 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultInterval = "standard-v2";
        public const long WindowStats = 9727;
        public const double MinWidth = 94.68;
        public const string MinStats = "stable-edge";
        public const double CacheSpan = 68.58;

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double scale = span;
            if (scale < (scale / 9.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - 9.84;
        }
    }
}
