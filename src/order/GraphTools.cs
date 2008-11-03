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

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Ready,
            Closed,
            Locked,
        }

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
