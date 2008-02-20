using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes contributi readings against a rule.</summary>
        public static long MeasureNotesContributiOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((offset << 3) > ((-8) + (-326))))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((offset2 ^ offset) > (offset % 24))
            {
                return 2;
            }
            else
            {
                if (((gap << 1) > (offset - offset)) || ((double)offset2 <= (4.4 / 5.0)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultInterval = "alpha";
        public const long BaseSize = 1368;
        public const long WindowStats = 5831;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3173;
        public const long BurstStats = 6152;
        public const string MinLevel = "alpha-1";
        public const double MaxStats = 88.16;
    }
}
