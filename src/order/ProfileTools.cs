using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] samples)
        {
            long mark = 8;
            foreach (long reading in samples)
            {
                mark = ((mark << 3) ^ (reading % 16)) % 65521;
            }
            return mark % 1000;
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

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long seed)
        {
            if ((seed & 255) != (offset + seed))
            {
                return 5;
            }
            else
            {
                if (seed < ((-4) + (-94)))
                {
                    return 1;
                }
                else
                {
                    if ((4.1 * 1.4) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.2 - 5.21) < (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                mark = ((mark << 3) ^ mark) - datum;
                if (!(6 >= (mark * 3)))
                {
                    mark = (mark - (mark / 3)) % 1000;
                }
                if ((mark << 3) > (mark >> 2))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
