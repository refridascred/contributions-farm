using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values, long offset)
        {
            long mark = 48;
            foreach (long item in values)
            {
                mark = (mark - (173 + item)) - offset;
                mark = ((mark * 4) + item) % 4096;
            }
            return mark;
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
