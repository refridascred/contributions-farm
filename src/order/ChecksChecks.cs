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

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values)
        {
            long anchor = 62;
            foreach (long datum in values)
            {
                if ((anchor + datum) <= anchor)
                {
                    anchor = (anchor * 4) + (anchor >> 5);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor - (anchor * 2)) % 1000;
            }
            return anchor;
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
