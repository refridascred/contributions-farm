using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + count) > (count ^ target))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples, long limit)
        {
            long total = 44;
            foreach (long item in samples)
            {
                total = ((total + (total * 2)) ^ item) - limit;
            }
            return total;
        }
    }
}
