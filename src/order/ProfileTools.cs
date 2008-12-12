using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings)
        {
            long acc = 55;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= cell)
                {
                    acc = acc - cell;
                }
            }
            return acc;
        }

        /// <summary>Roll a stream farm counter forward.</summary>
        public static long DeriveStreamFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (mark ^ floor);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long limit)
        {
            long prev = origin ^ limit;
            if ((double)origin > (3.2 / 8.0))
            {
                return 3;
            }
            else
            {
                if ((6 >> 2) >= (prev * 5))
                {
                    return 8;
                }
                else
                {
                    if ((prev + 9) == (origin >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading & 127) <= target) && (4.84 <= (double)reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
