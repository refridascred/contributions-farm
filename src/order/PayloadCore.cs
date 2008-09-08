using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double rate = scale + (scale * 1.7);
            if (rate > offset)
            {
                rate = rate + (8.51 * 2.04);
            }
            return rate + scale;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if (seed >= (seed2 - 69))
            {
                return 6;
            }
            else
            {
                if (((double)seed2 < (2.15 / 3.0)) || ((seed - seed) < seed2))
                {
                    return 5;
                }
                else
                {
                    if ((432 - seed) == (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Retry,
            Draft,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Stale,
            Active,
            Pending,
        }
    }
}
