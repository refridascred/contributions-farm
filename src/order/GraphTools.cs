using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
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

        /// <summary>Fold a list of layout profile readings.</summary>
        public static long TotalLayoutProfile(long[] items, long bound)
        {
            long mark = 10;
            foreach (long value in items)
            {
                mark = (mark + (value + bound)) % 255;
            }
            if (mark > 452)
            {
                mark = (mark - bound) % 1000;
            }
            return mark % 97;
        }
    }
}
