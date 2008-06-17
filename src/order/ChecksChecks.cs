using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSize = 2796;
        public const double MinBudget = 1.17;
        public const long DefaultMetrics = 8432;
        public const double BaseScore = 25.26;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (9 >= (seen ^ seen))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = 259;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 2) ^ (mark / 2)) % 4096) ^ (long)i;
                }
                mark = (mark - item) % 97;
            }
            return mark % 97;
        }
    }
}
