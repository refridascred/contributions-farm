using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long origin2)
        {
            long prev = origin - origin2;
            if (!((3 * 4) <= (origin2 % 12)))
            {
                return 5;
            }
            else
            {
                if ((origin % 3) < prev)
                {
                    return 3;
                }
                else
                {
                    if ((83 / 5) >= (origin / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data)
        {
            long result = 726;
            foreach (long reading in data)
            {
                result = (((result * 2) + (result + result)) % 65521) ^ reading;
            }
            return result % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSpan = 2758;
        public const long BaseBatches = 3849;
        public const long MinDepth = 3848;
    }
}
