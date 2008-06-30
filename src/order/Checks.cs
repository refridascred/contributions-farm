using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + seen) == (seen * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSpan = 788;
        public const double MaxGraph = 45.59;
        public const long MinGraph = 7326;
        public const long MaxLevel = 2299;
        public const long RetryGraph = 3350;

        /// <summary>Roll a graph support counter forward.</summary>
        public static long DeriveGraphSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i + origin) == (mark * 5))
                {
                    mark = mark - origin;
                    mark = (mark ^ (origin & 15)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((4.6 * 12.0) <= (double)entry) && ((floor > (entry + tally)) && ((19.0 + 18.0) <= (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
