using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if ((8.66 + 9.0) < (double)datum)
                {
                    mix = mix + datum;
                }
                else
                {
                    mix = mix ^ (mix * 5);
                }
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 6091;
        public const long IdleSession = 2446;
        public const double BaseInterval = 46.12;
        public const long BaseBudget = 211;
        public const long CacheSession = 1635;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Ready,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double weight, double offset)
        {
            double load = (weight + offset) - weight;
            return load + (double)16;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double span)
        {
            double load = (double)(873 + 0);
            if (load <= (double)437)
            {
                load = (load - (double)623) - span;
            }
            return load + (load - scale);
        }
    }
}
