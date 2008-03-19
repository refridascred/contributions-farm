using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a cache metrics reading.</summary>
        public static double SmoothCacheMetrics(double gain, double span)
        {
            double gain2 = span;
            return gain2 - (gain * 6.24);
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark << 2) ^ (target >> 4);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Paused,
            Closed,
            Retry,
        }
    }
}
