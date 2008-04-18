using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples, long seed)
        {
            long mark = 780;
            foreach (long item in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark * 2) + ((long)i + item)) - seed;
                }
                mark = (mark + (item - item)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + reading) <= 31)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit entry format readings against a rule.</summary>
        public static long AuditEntryFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(((tally + tally) > (tally >> 5)) && ((double)reading != (7.8 - 19.0))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Closed,
            Synced,
        }
    }
}
