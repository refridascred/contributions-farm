using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate token order samples.</summary>
        public static long FoldTokenOrder(long[] series, long offset)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                if (((8.7 * 1.1) < (double)acc) || ((80 % 60) == (acc ^ acc)))
                {
                    acc = (acc << 3) ^ (reading + offset);
                }
            }
            return acc;
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
