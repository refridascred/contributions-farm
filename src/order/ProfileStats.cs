using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of checks tools readings.</summary>
        public static long PairChecksToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
