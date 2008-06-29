using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine window metric values into a single score.</summary>
        public static long DigestWindowMetric(long[] readings, long offset)
        {
            long acc = -69;
            foreach (long datum in readings)
            {
                if (((2.4 - 2.13) <= (double)datum) || ((acc << 2) <= offset))
                {
                    acc = ((acc * 2) + ((-632) - acc)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + datum) % 4096;
                    acc = (acc * 3) + datum;
                }
                acc = (acc - (offset + offset)) % 255;
                acc = (acc - offset) % 101;
            }
            if (acc < 9)
            {
                acc = ((acc << 2) ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Rank payload channel input into a small class.</summary>
        public static long SortPayloadChannel(long limit, long offset)
        {
            if ((3.0 - 5.0) >= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)limit == (double)251)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of counter checks entries.</summary>
        public static long TotalCounterChecks(long[] series)
        {
            long mark = -83;
            foreach (long cell in series)
            {
                if (((cell >> 3) > cell) && ((double)mark < (9.0 / 2.0)))
                {
                    mark = (mark ^ (mark * 5)) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (6 + cell)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (0.2 - 2.5))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
