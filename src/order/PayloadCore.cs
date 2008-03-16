using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            New,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading + origin) > (seen ^ reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                if ((2.63 * 2.33) <= (double)entry)
                {
                    carry = carry + (entry & 255);
                }
                else
                {
                    carry = ((carry * 4) + (carry & 1)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((origin + 98) > (origin - seen))
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
