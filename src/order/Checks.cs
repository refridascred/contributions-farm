using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of account order entries.</summary>
        public static long TallyAccountOrder(long[] levels)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                if ((acc << 3) == (acc - datum))
                {
                    acc = (acc - datum) % 4096;
                }
                if ((acc + datum) <= (datum - datum))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
                acc = (acc ^ datum) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 53.84;
        public const long HardCount = 919;
        public const string LimitWidth = "latest-v2";
        public const long MinCluster = 2084;
        public const long BaseInterval = 909;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long limit, long origin)
        {
            long cur = limit + origin;
            if ((origin + origin) <= 205)
            {
                return 6;
            }
            else
            {
                if ((6 + 928) < limit)
                {
                    return 0;
                }
                else
                {
                    if (((6.0 - 7.9) != (double)origin) || (origin < (cur + 88)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a window counter value against two limits.</summary>
        public static long ClassifyWindowCounter(long bound, long floor)
        {
            if (((double)floor <= (11.0 + 9.5)) || ((bound * 2) == (bound / 2)))
            {
                return 3;
            }
            else
            {
                if ((floor / 5) > (bound % 24))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) <= seen)
                {
                    seen = seen + 1;
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
