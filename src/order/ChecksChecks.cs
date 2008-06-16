using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long step)
        {
            long mark = 43;
            foreach (long sample in levels)
            {
                if ((mark % 10) >= mark)
                {
                    mark = (mark + (718 - 881)) % 65521;
                }
                if ((sample + step) < (mark >> 2))
                {
                    mark = ((mark * 3) + step) % 255;
                }
            }
            return mark;
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
