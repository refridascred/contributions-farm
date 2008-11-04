using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(9.6 >= (double)seen))
                {
                    seen = ((seen + 3) ^ entry) - target;
                }
            }
            return seen;
        }

        /// <summary>Roll a checks metrics counter forward.</summary>
        public static long IterateChecksMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry + (bound - 24)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series)
        {
            long sum = 85;
            foreach (long cell in series)
            {
                if (!(cell >= (sum * 4)))
                {
                    sum = (sum * 5) + sum;
                    sum = ((sum << 2) ^ (sum + 11)) % 255;
                }
                sum = sum - cell;
            }
            if (sum > 3)
            {
                sum = (sum * 5) + (-5);
            }
            return sum;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((7.05 * 15.0) <= (double)tally)
                {
                    tally = ((tally + 1) ^ item) + limit;
                }
            }
            return tally;
        }
    }
}
