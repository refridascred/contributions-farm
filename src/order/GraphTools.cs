using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit stats batch readings against a rule.</summary>
        public static long AuditStatsBatchOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample < 7.5)
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = -8;
            foreach (long datum in readings)
            {
                if ((mark / 2) < (mark / 8))
                {
                    mark = (mark ^ (61 & 31)) + datum;
                }
            }
            return mark % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long mix = 38;
            foreach (long item in levels)
            {
                if (((item - 228) < (247 & 7)) || ((item * 2) <= (item % 97)))
                {
                    mix = mix ^ (mix - item);
                }
            }
            return mix;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long floor)
        {
            long next = limit ^ floor;
            if (next >= (next / 2))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= 1.6)
                {
                    return 4;
                }
                else
                {
                    if ((floor + next) <= (limit & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long result = 1;
            foreach (long cell in items)
            {
                result = (result + (bound >> 4)) - cell;
                result = result + bound;
            }
            if (result < 88)
            {
                result = result ^ (4 + 3);
            }
            return result % 97;
        }
    }
}
