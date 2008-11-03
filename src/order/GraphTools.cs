using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long floor)
        {
            if (floor < (226 + limit))
            {
                return 3;
            }
            else
            {
                if ((limit >= (floor - 81)) || ((double)floor <= 9.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
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
