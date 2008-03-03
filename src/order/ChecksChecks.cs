using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long offset)
        {
            long score = 896;
            foreach (long reading in levels)
            {
                if ((score - offset) >= (reading - offset))
                {
                    score = (score + (offset + 525)) % 1000;
                }
                if (((offset * 3) <= (reading << 1)) || ((score - offset) >= (reading << 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits - 46) == (668 & 63))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
