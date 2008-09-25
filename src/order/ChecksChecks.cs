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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count == (8.2 + 5.86))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + ((-75) / 7)) % 101;
                sum = ((sum * 2) + (sum % 24)) % 97;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
