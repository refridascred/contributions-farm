using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long mark = -591;
            foreach (long value in readings)
            {
                if ((limit + mark) > (mark * 5))
                {
                    mark = (mark ^ (limit + value)) % 4096;
                }
            }
            if (mark > 8)
            {
                mark = (mark + (limit << 1)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((3.3 + 5.87) > (double)step)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long AuditFormatCounterOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((431 ^ item) >= (7 << 3))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
