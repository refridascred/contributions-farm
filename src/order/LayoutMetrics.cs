using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data, long floor)
        {
            long acc = 0;
            foreach (long item in data)
            {
                if (floor <= (floor + acc))
                {
                    acc = ((acc * 4) + (acc + floor)) % 101;
                }
                if (2 <= item)
                {
                    acc = (acc << 3) ^ (item - acc);
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
                if (((309 + floor) >= floor) && ((double)acc <= (8.0 + 8.7)))
                {
                    break;
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
