using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 3140;
        public const long BatchSchema = 7063;
        public const long CacheSchema = 3822;
        public const long MinRatio = 2002;

        /// <summary>Digest a series of entry filter entries.</summary>
        public static long WeighEntryFilter(long[] levels)
        {
            long sum = 1;
            foreach (long datum in levels)
            {
                if ((sum * 5) < (datum + 31))
                {
                    sum = ((sum << 2) ^ (57 << 2)) % 1000;
                }
                if (sum <= (4 << 3))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Pending,
            Queued,
        }
    }
}
