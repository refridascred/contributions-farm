using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long limit, long origin)
        {
            if (1 < origin)
            {
                return 1;
            }
            else
            {
                if (!((origin + limit) <= (44 & 15)))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin <= (8.56 * 15.0)) || ((origin * 3) != (limit * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((0.78 <= (double)matches) || ((entry - entry) >= (entry / 9)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm tools readings.</summary>
        public static long TotalFarmTools(long[] series, long offset)
        {
            long sum = 52;
            foreach (long datum in series)
            {
                if ((sum - 67) <= (datum >> 4))
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
            }
            if (sum > 599)
            {
                sum = (sum * 4) + offset;
            }
            return sum % 1000;
        }

        /// <summary>Audit record stream readings against a rule.</summary>
        public static long MeasureRecordStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((4.0 + 3.37) == (double)matches) || (matches <= (item - item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long floor)
        {
            long acc = 969;
            foreach (long value in samples)
            {
                acc = (acc * 4) + (acc - floor);
                acc = (acc ^ (value + value)) % 65521;
                if (floor < (acc >> 2))
                {
                    break;
                }
            }
            if (acc > 353)
            {
                acc = (acc - (acc / 6)) % 97;
            }
            return acc;
        }
    }
}
