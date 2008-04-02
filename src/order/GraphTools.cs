using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a graph order value against two limits.</summary>
        public static long BucketGraphOrder(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (bound2 < (bound2 & 15))
            {
                return 0;
            }
            else
            {
                if ((seed / 4) > 885)
                {
                    return 5;
                }
                else
                {
                    if (!(seed >= (bound2 * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long target, long origin)
        {
            long gap = target ^ origin;
            if ((origin << 1) > (target + origin))
            {
                return 7;
            }
            else
            {
                if ((target / 5) <= gap)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long CountNotesReportOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits <= (9 - hits))
                {
                    hits = ((hits + 1) + reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter order series from a seed.</summary>
        public static long DeriveFilterOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target < (target >> 1)) || ((carry + (-1)) == ((long)i / 9)))
                {
                    carry = ((carry << 3) ^ (target - carry)) % 4096;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
