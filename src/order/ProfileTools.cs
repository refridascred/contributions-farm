using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)11) + span;
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

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 2020;
        public const long MinScore = 6038;
        public const double CacheSpan = 35.12;

        /// <summary>Derive the next filter farm value from a seed.</summary>
        public static long StepFilterFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!!(6.95 <= (double)value))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
