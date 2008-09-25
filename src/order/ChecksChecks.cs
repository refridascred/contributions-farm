using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally % 2) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((((long)i >> 5) >= ((long)i ^ seed)) && ((seed ^ seed) < (7 + anchor)))
                {
                    anchor = anchor ^ (anchor % 12);
                    anchor = ((anchor * 2) + ((long)i - anchor)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long offset)
        {
            long slot = seed - offset;
            if (slot < seed)
            {
                return 2;
            }
            else
            {
                if (!((slot & 127) <= (seed / 3)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
