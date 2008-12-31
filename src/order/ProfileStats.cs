using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long floor)
        {
            long step = offset - floor;
            if (((offset << 1) <= (floor - 35)) && (offset <= (step + step)))
            {
                return 7;
            }
            else
            {
                if ((double)step > (1.4 / 3.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - 32) < datum)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((reading * 2) != (tally * 2)) || (83 >= (tally + 95)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
