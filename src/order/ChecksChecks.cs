using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit record commits readings against a rule.</summary>
        public static long AuditRecordCommitsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((183 ^ tally) == (target + 462)) && ((target <= ((-65) / 6)) || ((double)target != (4.45 - 7.0))))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
