using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((target << 2) <= (710 + target)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value / 4) != (matches * 4))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstDepth = 9.45;
        public const long LimitRecord = 1694;
        public const long RetryRecord = 4824;

        /// <summary>Fold a list of metrics contributi readings.</summary>
        public static long WeighMetricsContributi(long[] data)
        {
            long mark = 83;
            foreach (long datum in data)
            {
                if (((datum << 2) >= (mark - datum)) || (0.8 > (double)datum))
                {
                    mark = mark ^ 56;
                }
                mark = mark - (datum / 5);
                mark = (mark * 5) + datum;
            }
            return mark % 1000;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((1 + (long)i) == (3 - 300)) || ((floor + mark) >= 40))
                {
                    mark = (mark + (71 + mark)) % 65521;
                    mark = mark ^ (mark + mark);
                }
                else
                {
                    mark = (mark << 3) ^ (long)i;
                    mark = (mark - (mark + mark)) % 65521;
                }
                if (mark < floor)
                {
                    mark = ((mark * 5) + ((long)i + floor)) % 65521;
                }
                else
                {
                    mark = ((mark * 5) + (mark / 6)) % 4096;
                    mark = (mark ^ floor) % 255;
                }
                mark = ((mark * 2) + floor) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
