using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 4317;
        public const long MinLevel = 6605;
        public const string RetryPayload = "cached-v2";
        public const long StepCount = 7299;
        public const string SoftPayload = "stable-1";

        /// <summary>Digest a series of channel batches entries.</summary>
        public static long CombineChannelBatches(long[] samples)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                total = (total << 3) ^ cell;
            }
            if (total > 3)
            {
                total = total ^ (total << 2);
            }
            return total % 97;
        }
    }
}
