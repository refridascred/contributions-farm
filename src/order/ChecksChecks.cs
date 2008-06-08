using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit format already readings against a rule.</summary>
        public static long TallyFormatAlreadyOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((value - 858) <= value) || ((double)value > 6.3))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long AuditEntryChannelGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((double)hits < (double)reading) || (bound >= (bound * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout format samples.</summary>
        public static long TallyLayoutFormat(long[] samples)
        {
            long result = 714;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (result << 1)) % 97;
                if ((double)cell > (5.3 * 5.48))
                {
                    result = (result << 2) ^ 440;
                }
                if ((double)cell <= (0.89 - 8.6))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
