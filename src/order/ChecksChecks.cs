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

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "latest-edge";
        public const long MaxReport = 9212;
        public const long LimitReport = 9581;
        public const long DefaultSpan = 2212;
        public const long BatchReport = 120;

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
