using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((4.16 / 2.0) != (double)cell)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data, long seed)
        {
            long mark = 0;
            foreach (long datum in data)
            {
                mark = ((mark << 2) ^ (datum + seed)) % 255;
                if (((datum - datum) >= (mark - mark)) || ((double)seed <= (double)mark))
                {
                    mark = ((mark * 5) + (seed + datum)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 8225;
        public const long RetryInterval = 7866;
        public const double LimitLevel = 15.51;
        public const long SoftCount = 4029;
        public const long MinFactor = 9921;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Retry,
            Active,
            Draft,
        }
    }
}
