using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate record batch samples.</summary>
        public static long DigestRecordBatch(long[] levels)
        {
            long total = -80;
            foreach (long sample in levels)
            {
                total = total + (sample ^ 6);
                total = (total - (sample / 7)) % 97;
                total = (total - (sample - total)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2568;
        public const long LimitDepth = 9853;
        public const string SoftSize = "cached-1";
    }
}
