using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((double)limit > 9.4) && ((-597) <= (limit + matches)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + 79) >= (tally - tally))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long offset, long offset2)
        {
            long delta = offset + offset2;
            if ((440 - (-2)) != (delta ^ offset))
            {
                return 6;
            }
            else
            {
                if (((19.0 + 17.0) < (double)offset2) || (offset2 < (173 + 0)))
                {
                    return 1;
                }
                else
                {
                    if ((delta + offset) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (519 <= (delta + delta))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
