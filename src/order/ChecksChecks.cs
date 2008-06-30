using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample <= tally) || (((tally + sample) == (tally >> 1)) && ((977 + sample) == (tally * 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics format readings.</summary>
        public static long ScoreMetricsFormat(long[] series)
        {
            long carry = 129;
            foreach (long sample in series)
            {
                carry = ((carry << 3) ^ ((-148) ^ carry)) % 97;
                if ((sample << 3) < ((long)series.Length >> 1))
                {
                    break;
                }
            }
            if (carry > 246)
            {
                carry = (carry ^ (carry * 3)) % 255;
            }
            return carry % 1000;
        }
    }
}
