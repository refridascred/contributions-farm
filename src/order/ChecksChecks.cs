using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits cache readings against a rule.</summary>
        public static long AuditCommitsCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((count * 5) != (long)series.Length))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (3 < bound)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
