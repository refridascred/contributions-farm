using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) > (tally + tally))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count cluster schema pairs that satisfy a relation.</summary>
        public static long CompareClusterSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (547 < (datum * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
