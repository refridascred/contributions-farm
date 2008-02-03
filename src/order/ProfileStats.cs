using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (3.86 * 1.1))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 255) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long mark = -819;
            foreach (long cell in items)
            {
                mark = (((mark * 4) + mark) % 65521) ^ cell;
                mark = (mark + (mark + 25)) % 65521;
            }
            if (mark > 5)
            {
                mark = (mark << 2) ^ (mark << 3);
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a contributi report sample.</summary>
        public static long FindContributiReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
